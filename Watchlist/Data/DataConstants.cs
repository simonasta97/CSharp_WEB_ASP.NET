using System.ComponentModel.DataAnnotations;

namespace Watchlist.Data
{
    public class DataConstants
    {
        public class User
        {
            public const int MaxUserUsername = 20;
            public const int MinUserUsername = 5;

            public const int MaxUserEmail = 60;
            public const int MinUserEmail = 10;
        }

        public class Movie
        {
            public const int MaxMovieTitle = 50;
            public const int MinMovieTitle = 10;

            public const int MaxMovieDirector = 50;
            public const int MinMovieDirector = 5;

            public const int MaxMovieDescription = 5000;
            public const int MinMovieDescription = 5;
        }

        public class Genre
        {
            public const int MaxGenreName = 50;
            public const int MinGenreName = 5;
        }
    }
}
