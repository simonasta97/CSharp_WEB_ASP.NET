namespace Watchlist.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using Watchlist.Data.Models;
    using static Watchlist.Data.DataConstants.User;

    public class User : IdentityUser
    {
        public ICollection<UserMovie> UsersMovies { get; set; } = new HashSet<UserMovie>();
    }
}
