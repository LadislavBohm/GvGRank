using System.ComponentModel.DataAnnotations;

namespace GvGRank_Server.Models
{
	public class IP
	{
		// 132 bytes per row

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(64)] // SHA256 hash of IP address
		public string Ip { get; set; }
	}
}
