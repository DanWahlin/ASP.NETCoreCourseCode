using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMovies.Models;

namespace RazorMovies.Pages
{
    public class IndexModel : PageModel
    {
        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            var movies = new List<Movie> {
                new Movie { Id=1, Title="Star Wars", Director="George Lucas"},
                new Movie { Id=2, Title="Empire Strikes Back", Director="George Lucas"},
                new Movie { Id=3, Title="Star Wars", Director="George Lucas"},
            };
            Movies = movies;
        }
    }
}
