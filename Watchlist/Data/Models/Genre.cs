namespace Watchlist.Data
{
    using System.ComponentModel.DataAnnotations;
    using static Watchlist.Data.DataConstants.Genre;

    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxGenreName)]
        public string Name { get; set; }
    }
}
