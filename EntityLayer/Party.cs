using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Party
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location {get; set;} 

        //foreignKey 
        [ForeignKey("PolyClass")]
        public int PolyClassReference { get; set; }
        public PolyClass PolyClass { get; set; }
    }
}
