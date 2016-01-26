using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webplatform.Models.Forms
{
    public class NewUser
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Brugernavn")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(4)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Gentag Password")]
        [Compare("Password", ErrorMessage = "Password'et er ikke ens")]
        public string RepeatPassword { get; set; }
    }
}