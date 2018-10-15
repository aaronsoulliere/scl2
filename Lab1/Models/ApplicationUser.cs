using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Lab1.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        public string Company { set; get; }
        public string Position { set; get; }
        [Required]
        public DateTime BirthDate { set; get; }
    }
}
