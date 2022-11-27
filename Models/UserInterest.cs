using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise.Models
{
    public class UserInterest
    {
        
        #region Props
        public int UserId { get; set; }
        public virtual WiseUser User { get; set; }

        public int InterestId { get; set; }
        public virtual 

        [Key]
        [ForeignKey ("WiseUser")]
        public int IdUser { get; set; }
        [Key]
        [ForeignKey("Interests")]
        public string IdInterest { get; set; }
        #endregion
        
        
        #region Relationships
        //TODO: Create relations
        public WiseUser WiseUser { get; set; }
        public Interest Interests { get; set; }
        #endregion
    }
}
