namespace Watchlist.Data
{
    using Microsoft.AspNetCore.Mvc;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Watchlist.Data.DataConstants.Movie;

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxMovieTitle)]
        public string Title { get; set; }

        [Required]
        [MaxLength(MaxMovieDirector)]
        public string Director { get; set; }

        [Required]
        [MaxLength(MaxMovieDescription)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }

        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
