using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Car
    {
        [Required]
        public int ID { set; get; }
        [Required]
        public string Make { set; get; }
        [Required]
        public string Model { set; get; }
        [Required]
        public int Year { set; get; }
        [Required]
        public string VIN { set; get; }
        public string Color { set; get; }
        public int DealershipID { set; get; }
    }
}
