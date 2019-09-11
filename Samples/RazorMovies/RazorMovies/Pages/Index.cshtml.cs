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
    public class IndexModel : PageModel
    {
        IMovieRepository _repo;
        public List<Movie> Movies { get; set; }

        public IndexModel(IMovieRepository repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
            Movies = _repo.GetMovies();
        }
    }
}
