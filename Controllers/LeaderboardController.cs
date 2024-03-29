﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GvGRank_Server.Models;

namespace GvGRank_Server.Controllers
{
	[Route("api/Leaderboard")]
	[ApiController]
	public class LeaderboardController : ControllerBase
	{
		private VoteDbContext _context;

		public LeaderboardController(VoteDbContext context)
		{
			_context = context;
		}

		// GET api/leaderboard
		[HttpGet]
		public string[] Get()
		{
            const int minVotesToShow = 10;

			return _context.Players
				.OrderByDescending(x => x.Shitlo)
                .Where(x => x.Wins + x.Losses >= minVotesToShow)
				.Select(x => x.Name /*+ " - " + x.Shitlo.ToString()*/)
				.ToArray();
		}
	}
}