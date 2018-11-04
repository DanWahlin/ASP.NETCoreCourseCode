using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMovies.Models;

namespace RazorMovies.Pages
{
    public class MovieModel : PageModel
    {
        public Movie Movie { get; set; }

        public void OnGet(int id = 0)
        {
            Movie = new Movie { Id = id, Title = "Star Wars", Director = "George Lucas" };
        }
    }
}