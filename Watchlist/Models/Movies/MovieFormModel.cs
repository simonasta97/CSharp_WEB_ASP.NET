namespace Watchlist.Models.Movies
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Linq;
    using Watchlist.Data;
    using static Watchlist.Data.DataConstants.Movie;

    public class MovieFormModel
    {
        [Required]
        [StringLength(MaxMovieTitle, MinimumLength = MinMovieTitle, ErrorMessage = "Title should be at least {2} characters long.")]
        public string Title { get; set; }

        [Required]
        [StringLength(MaxMovieDirector, MinimumLength = MinMovieDirector, ErrorMessage = "Director should be at least {2} characters long.")]
        public string Director { get; set; }

        [Required]
        [StringLength(MaxMovieDescription, MinimumLength = MinMovieDescription, ErrorMessage = "Description should be at least {2} characters long.")]
        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        [Range(0.00,10.00)]
        public decimal Rating { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public IEnumerable<MovieGenreModel> Genres { get; set; }
    }
}
