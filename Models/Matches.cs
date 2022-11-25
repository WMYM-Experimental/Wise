using System.ComponentModel.DataAnnotations;

namespace Wise.Models
{
    public class Matches
    {
        #region Props
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdPersonA { get; set; }

        [Required]
        public int IdPersonB { get; set; }

        [Required]
        public DateTime DateMatch { get; set; }

        [Required]
        public int Score { get; set; }

        //STREAKS??
        #endregion

        #region Relationships
        //TODO: Create relations
        #endregion


    }
}
