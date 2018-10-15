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
