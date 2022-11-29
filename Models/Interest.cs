using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise.Models
{
    public class Interest
    {
        #region Props
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        #endregion

        #region Relationships
        public int UserId { get; set; }
        public WiseUser User { get; set; }
        #endregion


    }
}
