using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GvGRank_Server.Models
{
	public class Player
	{
		// 56 bytes per row

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(20)] // Maximum Guild Wars player name length
		public string Name { get; set; }

		[DefaultValue(0)] // Median rating should be zero
		public int Shitlo { get; set; } = 0; // Thanks Eight Bit for christening our rating system

		// These next two aren't used for anything, but may be interesting to look at.

		[DefaultValue(0)]
		public int Wins { get; set; } = 0;

		[DefaultValue(0)]
		public int Losses { get; set; } = 0;
	}
}
