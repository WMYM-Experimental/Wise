using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise.Models
{
    internal class User_interests
    {
        /*
        #region Props
        [Key]
        [ForeignKey ("WiseUser")]
        public int IdUser { get; set; }
        [Key]
        [ForeignKey("Interests")]
        public string IdInterest { get; set; }
        #endregion
        */

        
        #region Relationships
        //TODO: Create relations
        public WiseUser WiseUser { get; set; }
        public Interests Interests { get; set; }
        #endregion
    }
}
