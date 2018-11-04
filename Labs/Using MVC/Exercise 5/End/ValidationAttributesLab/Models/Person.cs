using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationAttributesLab.Models
{
    public class Person
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(6)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$")]
        public string SSN { get; set; }
    }
}
