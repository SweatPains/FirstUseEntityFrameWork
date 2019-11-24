using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class PolyClass
    {
        [Key]
        public int ID { get; set; }

        public ICollection<Party> Parties { get; set; }

    }
}
