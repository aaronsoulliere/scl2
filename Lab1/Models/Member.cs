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
    public class Member
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { set; get; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { set; get; }
        [Required]
        [Key]
        public string UserName
        {
            set
            {
                _username = value;
            }
            get
            {
                return _username == "" ? Email : _username;
            }
        }
        private string _username = "";
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { set; get; }
        public string Company { set; get; }
        public string Position { set; get; }
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { set; get; }
    }
}
