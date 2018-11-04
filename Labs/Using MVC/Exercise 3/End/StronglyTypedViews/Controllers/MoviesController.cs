using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedViews.Models;

namespace StronglyTypedViews.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var vm = new MoviesViewModel
            {
                Movies = new List<Movie>
                {
                    new Movie { Id=1, Title="Star Wars", Director="George Lucas"},
                    new Movie { Id=2, Title="Lord of the Rings", Director="Peter Jackson"}
                },
                MovieCategories = new List<MovieCategory>
                {
                    new MovieCategory { Id=1, Genre="Action"},
                    new MovieCategory { Id=2, Genre="SciFi"},
                }
            };
            return View(vm);
        }
    }
}