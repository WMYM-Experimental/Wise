using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise.Models
{
    public class Likes
    {
        #region Props
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdLiker { get; set; }
        [Required]
        public int IdLiked { get; set; }
        [Required]
        public DateTime Date { get; set; }
        #endregion

        #region Relationships
        //TODO: Create relations
        #endregion

    }
}
