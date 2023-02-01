using System.ComponentModel.DataAnnotations;

namespace Wise.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MatchId { get; set; }
        public bool Matched { get; set; }
    }
}
