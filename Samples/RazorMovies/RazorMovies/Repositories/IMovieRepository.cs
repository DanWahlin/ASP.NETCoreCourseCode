using System.Collections.Generic;
using RazorMovies.Models;

namespace RazorMovies.Repositories
{
    public interface IMovieRepository
    {
        Movie GetMovie(int id);
        List<Movie> GetMovies();
    }
}