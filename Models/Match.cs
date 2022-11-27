using System.ComponentModel.DataAnnotations;

namespace Wise.Models
{
    public class Match
    {
        #region Props
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateMatch { get; set; }

        [Required]
        public int Score { get; set; }

        //STREAKS??
        #endregion

        #region Relationships
        public int PersonAId { get; set; }
        public virtual WiseUser PersonA { get; set; }
        public int PersonBId { get; set; }
        public virtual WiseUser PersonB { get; set; }
        #endregion


    }
}
