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

        #region Relationships
        public int UserId { get; set; }
        public virtual WiseUser User { get; set; }
        public int InterestId { get; set; }
        public virtual Interest Interest { get; set; }
        #endregion

    }
}
