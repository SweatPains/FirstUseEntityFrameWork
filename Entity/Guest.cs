using System;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Entity
{
    public class Guest
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
