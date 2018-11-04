using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBinderLab.Models;

namespace ModelBinderLab.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                // Would insert movie into a data store here
                Console.WriteLine(movie.Title);
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}