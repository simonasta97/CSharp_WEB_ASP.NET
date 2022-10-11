using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.ViewModels
{
    public class RegisterViewModel
    {
        [StringLength(20, MinimumLength = 5)]
        public string Username { get; set; }

        [StringLength(60, MinimumLength = 10)]
        public string Email { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
