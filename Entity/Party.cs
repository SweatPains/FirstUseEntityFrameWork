using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Party
    {
        [ForeignKey("Guest")]
        [Key]
        public int PartyID { get; set; }
        public string Name { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
