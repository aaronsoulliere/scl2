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
    public class Dealership
    {
        [Required]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
    }
}
