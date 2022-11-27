using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise.Models
{
    public class Like
    {
        #region Props
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        #endregion

        #region Relationships
        public int LikerId { get; set; }
        public virtual WiseUser Liker { get; set; }
        public int LikedId { get; set; }
        public virtual WiseUser Liked { get; set; }
        #endregion

    }
}
