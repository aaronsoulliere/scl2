// I, Aaron Soulliere, student number 000076628, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

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
