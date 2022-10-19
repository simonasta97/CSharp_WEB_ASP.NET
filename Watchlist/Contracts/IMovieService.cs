using Watchlist.Data;
using Watchlist.Data.Models;
using Watchlist.Models.Movies;

namespace Watchlist.Contracts
{
    public interface IMovieService
    {
        Task <IEnumerable<MovieViewModel>> GetAll();

        Task<IEnumerable<Genre>> GetGenres();

        Task Add(AddMovieViewModel model);

    }
}
