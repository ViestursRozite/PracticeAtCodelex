using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Movie
    {
        string title;
        string studio;
        string rating;

        public Movie(string title, string studio, string rating = "PG")
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }

        public Movie[] GetPG(Movie[] arrayMovies)
        {
            //                                PG tagged movies
             return  arrayMovies.Where(movie => movie.rating == "PG").ToArray();
        }

        public double AverageRating()
        {
            return 0;
        }

        public bool Available()
        {
            return true;
        }

        public string Title => "";

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
