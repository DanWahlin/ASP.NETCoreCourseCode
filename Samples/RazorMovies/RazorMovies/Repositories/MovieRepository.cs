using RazorMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMovies.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> movies = new List<Movie>()
            {
                new Movie(){Id = 1, Title = "Thor: Ragnarok", Director = "Taika Watiti", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/A1HBBNzBdxL._SY679_.jpg"},
                new Movie(){Id = 2, Title = "Reservoir Dogs", Director = "Quentin Tarantino", ImageUrl = "https://www.rarerecords.com.au/wp-content/uploads/2016/05/RESERVOIR-DOGS-Reservoir-Dogs-Movie-Poster.jpg"},
                new Movie(){Id = 3, Title = "Jurassic Park", Director = "Steven Spielberg", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41P-6BnVLbL.jpg"},
                new Movie(){Id = 4, Title = "Kill Bill Vol. 1", Director = "Quentin Tantino", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/514x9BnbLrL.jpg"}
            };
        public List<Movie> GetMovies()
        {
            return movies;
        }
        public Movie GetMovie(int id)
        {
            return movies.Where(m => m.Id == id).SingleOrDefault();
        }
    }
}
