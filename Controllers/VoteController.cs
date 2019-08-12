using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GvGRank_Server.Models;
using GvGRank_Server.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace GvGRank_Server.Controllers
{
	[Route("api/vote")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private VoteDbContext _context;
        private IHubContext<VoteHub> _hub;
        private static Random _random = new Random();

		public VoteController(VoteDbContext context, IHubContext<VoteHub> hub)
        {
            _context = context;
            _hub = hub;
		}

		// GET: api/Vote
		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				int ipId = GetIpId();


				// List of votes the user has already made

                IQueryable<Tuple<int, int>> clientExistingVotes =
					_context.Votes
					.Where(x => x.IpId == ipId)
					.Select(x => Tuple.Create(Math.Min(x.WinId, x.LoseId), Math.Max(x.WinId, x.LoseId)));


				// List of votes the user can make 

				IQueryable<Tuple<int, int>> validVotes = from set1 in _context.Players.Select(x => x.Id)
														 from set2 in _context.Players.Select(x => x.Id)
														 where set1 < set2 // this part prevents both xx & xy/yx duplicates, thanks for the advice dad
														 select Tuple.Create(set1, set2);

				if (validVotes.Count() != clientExistingVotes.Count())
				{
					validVotes = validVotes.Except(clientExistingVotes); // If the user hasn't made all possible votes, subtract the lists. If you've voted on everyone, you get an unfiltered vote combo back which won't pass validation in Post()
				}


				// Return randomly from what remains

				int    randomIndex = _random.Next(validVotes.Count()) - 1;
				int    player1Id   = validVotes.Skip(randomIndex).FirstOrDefault().Item1;
				int    player2Id   = validVotes.Skip(randomIndex).FirstOrDefault().Item2;
				string player1Name = _context.Players.Where(x => x.Id == player1Id).SingleOrDefault().Name;
				string player2Name = _context.Players.Where(x => x.Id == player2Id).SingleOrDefault().Name;

				return new OkObjectResult(new
				{
					name1 = player1Name,
					name2 = player2Name,
					id1   = player1Id,
					id2   = player2Id
				});
			}
			catch
			{
				return NotFound();
			}
		}

		// POST: api/Vote
		public StatusCodeResult Post([FromBody]VotePost v)
		{
			int ipId = GetIpId();


			// Make sure the call isn't malformed

			if (!ModelState.IsValid || v.WinId == v.LoseId)
			{
				//return BadRequest();
				return StatusCode(400);
			}


			// Check if the player names are valid

			if (! _context.Players.Where(x => x.Id == v.WinId).Any()
				|| ! _context.Players.Where(x => x.Id == v.LoseId).Any())
			{
				//return BadRequest();
				return StatusCode(400);
			}


			// Check if the user has made this vote combination before

			bool hasUserMadeThisVote = (from votes in _context.Votes
										where votes.IpId == ipId
											&& votes.WinId == v.WinId
											&& votes.LoseId == v.LoseId
										select votes).Any();

			bool hasUserMadeOppositeVote = (from votes in _context.Votes
											where votes.IpId == ipId
												&& votes.WinId == v.LoseId
												&& votes.LoseId == v.WinId
											select votes).Any();

			if (hasUserMadeThisVote	|| hasUserMadeOppositeVote)
			{
				//return Forbid();
				return StatusCode(403);
			}


			// Prepare data

			Player playerWin  = _context.Players.Where(x => x.Id == v.WinId).SingleOrDefault();
			Player playerLose = _context.Players.Where(x => x.Id == v.LoseId).SingleOrDefault();

			_context.Update(playerWin);
			_context.Update(playerLose);


			// Update vote counts

			playerWin.Wins++;
			playerLose.Losses++;


			// Calculate change in player rating

			int oldWinRating  = playerWin.Shitlo;
			int oldLoseRating = playerLose.Shitlo;
			int ratingDiff    = Math.Abs(oldWinRating - oldLoseRating);

			const int MIN_CHANGE  =  1; // Minimum rating change for a comparison
			const int MAX_CHANGE  = 50; // Maximum rating change for a comparison
			const int EVEN_CHANGE = 15; // Rating change for an even comparison

			const double EULERS_NUMBER      =  2.71828; //                                  	 |   1000 beats 1000 -> +/- 15
			const double EXPECTED_SCALING   = -0.00264; // k value of    15 e^(-k 500) = 4  	 |   1500 beats 1000 -> +/- 4
			const double UNEXPECTED_SCALING =  0.00240; // k value of    15 e^( k 500) = 50 	 |   1000 beats 1500 -> +/- 50
			
			double CalcRatingChange(double scaling) { return EVEN_CHANGE * Math.Pow(EULERS_NUMBER, scaling * ratingDiff); } // Ae^(kx), HUGE thanks to Itheory and Eight Bit for the formula & helping me implement it. 

			int change = Convert.ToInt32((oldWinRating >= oldLoseRating) ? Math.Max(CalcRatingChange(EXPECTED_SCALING),   MIN_CHANGE)   // Expected result
																		 : Math.Min(CalcRatingChange(UNEXPECTED_SCALING), MAX_CHANGE)); // Unexpected result

			playerWin.Shitlo   = oldWinRating  + change;
			playerLose.Shitlo  = oldLoseRating - change;


			// Save vote to database

			Vote vote = new Vote
			{
				Date   = DateTime.Now,
				IpId   = ipId,
				WinId  = v.WinId,
				LoseId = v.LoseId
			};

			_context.Votes.Add(vote);


            // Send this vote to subscribed clients

            _hub.Clients.All.SendAsync("recentvote", new string[] { playerWin.Name, playerLose.Name });


			// Commit changes & return success

			_context.SaveChanges(); // TODO: return different status code if this fails

			//return Ok();
			return StatusCode(201);
		}

		private int GetIpId() 
		{
			string ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
			
			ip = GetStringSha256Hash(ip);

			int id = 0;

			if (_context.IPs.Where(x => x.Ip == ip).Any()) // If this is a returning IP, fetch their ID
			{
				id = _context.IPs.Where(x => x.Ip == ip).SingleOrDefault().Id;
			}
			else // Otherwise, create a new entry in the IP table and return the ID
			{
				IP newIP = new IP { Ip = ip };

				_context.IPs.Add(newIP);
				_context.SaveChanges();

				id = newIP.Id;
			}

			return id;
		}

		private string GetStringSha256Hash(string text) // Hiding the IP so that people don't get upset about me storing it. https://stackoverflow.com/a/21109622/10874809
		{
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}

			using (System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed())
			{
				byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
				byte[] hash     = sha.ComputeHash(textData);

				return BitConverter.ToString(hash).Replace("-", string.Empty);
			}
		}
	}
}