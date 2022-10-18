namespace Watchlist.Models.User
{
    using System.ComponentModel.DataAnnotations;
    using static Watchlist.Data.DataConstants.User;
    public class RegisterModel
    {
        [Required]
        [StringLength(MaxUserUsername, MinimumLength = MinUserUsername)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(MaxUserEmail,MinimumLength = MinUserEmail)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        [Compare(nameof(ConfirmPassword))]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
