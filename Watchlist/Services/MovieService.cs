using Microsoft.EntityFrameworkCore;
using Watchlist.Contracts;
using Watchlist.Data;
using Watchlist.Data.Common;
using Watchlist.Data.Models;
using Watchlist.Models.Movies;

namespace Watchlist.Services
{
    public class MovieService : IMovieService
    {
        private readonly WatchlistDbContext data;

        public MovieService(WatchlistDbContext _context)
        {
            data = _context;
        }

        public async Task<IEnumerable<MovieViewModel>> GetAll()
        {
            var entities = await data.Movies
                .Include(m => m.Genre)
                .ToListAsync();

            return entities
                .Select(m => new MovieViewModel()
                {
                    Director = m.Director,
                    Genre = m?.Genre?.Name,
                    Id = m.Id,
                    ImageUrl = m.ImageUrl,
                    Rating = m.Rating,
                    Title = m.Title
                });
        }

        public async Task<IEnumerable<Genre>> GetGenres()
        {
            return await data.Genres.ToListAsync();
        }

        public async Task Add(AddMovieViewModel model)
        {
            var movie = new Movie()
            {
                Title = model.Title,
                Director = model.Director,
                ImageUrl = model.ImageUrl,
                Rating = model.Rating,
                GenreId = model.GenreId
            };

            await data.Movies.AddAsync(movie);
            await data.SaveChangesAsync();
        }

    }
}
