using Microsoft.EntityFrameworkCore;

namespace GvGRank_Server.Models
{
	public class VoteDbContext : DbContext
	{
		public DbSet<Player> Players { get; set; }
		public DbSet<Vote>   Votes   { get; set; }
		public DbSet<IP>     IPs     { get; set; }

		public VoteDbContext(DbContextOptions<VoteDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{
			string[] playerNames =
			{
				"Aspect",
				"Lynie",
				"Vesto",
				"Maverick",
				"Purif",
				"Willy",
				"Sam",
				"Ice",
				"Oln",
				"Fluxy",
				"Takida",
				"Butters",
				"Dopos",
				"Yoko",
				"Candyboy",
				"Rainy",
				"Akemi",
				"Lisek",
				"Kay",
				"Sven",
				"Teddy",
				"Brent",
				"Ali",
				"Kasperov",
				"Holye",
				"Nihal",
				"Yamamoto",
				"Motoko",
				"Chunin",
				"Newty",
				"Zynkh",
				"Honk",
				"Sebbe",
				"Fate",
				"Lao",
				"Messy",
				"Spartan",
				"Chamalee",
				"Maga",
				"Lua Kavanuh",
				"Izzy",
				"Remede",
				"Pally",
				"Jonas",
				"Eraziel",
				"Santana",
				"Yoshi",
				"Rudi",
				"Nick",
				"Mario",
				"Math",
				"Hemo",
				"Hash",
				"Miru",
				"Sync",
				"Moo",
				"Bounty",
				"Tequila",
				"Resi",
				"KO",
				"Jacke",
				"Demon",
				"Jake",
				"Beware",
				"Gatos",
				"Azin",
				"Jorn",
				"Chrizzo",
				"Matze",
				"Saints",
				"Pfefferkuchen",
				"Smoki",
				"Dome",
				"Trunkz"
			};

			int counter = 1;

			foreach (string playerName in playerNames)
			{
				modelbuilder.Entity<Player>().HasData(new Player() { Id = counter++, Name = playerName });
			}
		}
	}
}