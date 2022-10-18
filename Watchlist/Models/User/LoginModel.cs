using System.ComponentModel.DataAnnotations;

namespace Watchlist.Models.User
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [UIHint("hidden")]
        public string? ReturnUrl { get; set; }
    }
}
