using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMovies.Models;
using RazorMovies.Repositories;

namespace RazorMovies.Pages
{
    public class MovieModel : PageModel
    {
        IMovieRepository _repo;
        public Movie Movie { get; set; }

        public MovieModel(IMovieRepository repo)
        {
            _repo = repo;
        }
        public void OnGet(int id = 1)
        {
            Movie = _repo.GetMovie(id);
        }
    }
}