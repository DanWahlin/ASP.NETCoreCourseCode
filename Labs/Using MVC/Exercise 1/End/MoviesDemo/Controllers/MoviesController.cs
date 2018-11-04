using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesDemo.Models;

namespace MoviesDemo.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var repo = new MoviesRepository();
            var movies = repo.List();
            return View(movies);
        }
    }
}