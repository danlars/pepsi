using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webplatform.Models.Forms
{
    public class Login
    {
        [Display(Name = "Brugernavn")]
        [Required(ErrorMessage = "Brugernavn er påkrævet")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password er påkrævet")]
        [MinLength(4, ErrorMessage = "Password skal være på mindst 4 karakterer")]
        public string Password { get; set; }

    }
}