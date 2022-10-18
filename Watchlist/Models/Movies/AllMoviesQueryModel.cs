using Watchlist.Data;

namespace Watchlist.Models.Movies
{
    public class AllMoviesQueryModel
    {
        public AllMoviesQueryModel()
        {
            this.Movies = new HashSet<MovieFormModel>();
        }
        public IEnumerable<MovieFormModel> Movies { get; set; }

    }
}
