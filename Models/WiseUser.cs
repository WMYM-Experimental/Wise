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
        public string Nationality { get; set; }
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
        public List<string> SexualPreferences { get; set; }

        public string Pic { get; set; }

        #endregion
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public int elo { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }
        public string religion { get; set; }
        public string zoodiacalSign { get; set; }
        public bool isSmoker { get; set; }
        public bool isDrinker { get; set; }
        public string university { get; set; }
        public string work { get; set; }
        public DateTime birthday { get; set; }
        public DateTime lastOnline { get; set; }
        public string profilePicture { get; set; }
        public string sexualOrientation { get; set; }
        public string lookingFor { get; set; }
        public string personality { get; set; }

        #region Relationships
        // Todo: Make a tabel for matches and likes
        #endregion
    }
}