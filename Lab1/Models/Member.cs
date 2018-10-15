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
        public string FirstName { set; get; }
        [Required]
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
                return _username == "" ? FirstName + "." + LastName : _username;
            }
        }
        private string _username = "";
        [Required]
        public string Email { set; get; }
        public string Company { set; get; }
        public string Position { set; get; }
        public DateTime? BirthDate { set; get; }
    }
}
