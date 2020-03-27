using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Boolean to determine whether the user should be logged in with a session cookie or a persistent cookie
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
