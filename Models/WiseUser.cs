using System.ComponentModel.DataAnnotations;

namespace Wise.Models
{
    public class WiseUser
    {
        #region Props
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public int Elo { get; set; }
        [Required]
        public int Gender { get; set; }
        public string Nacionality { get; set; }
        public int Sign { get; set; }
        public int IsSmoker { get; set; }
        public int IsDrinker { get; set; }
        public string University { get; set; }
        public string Work { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime LastOnline { get; set; }

        [Required]
        public byte[] MainPic { get; set; }
        [Required]
        public string[] SexualPreferences { get; set; }
        #endregion

        #region Relationships
        // Todo: Make a tabel for matches and likes
        #endregion
    }
}