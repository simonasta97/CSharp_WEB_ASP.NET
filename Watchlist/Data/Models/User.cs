namespace Watchlist.Data
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static Watchlist.Data.DataConstants.User;

    public class User : IdentityUser
    {
        public ICollection<Movie> WatchedMovies { get; set; } = new HashSet<Movie>();
    }
}
