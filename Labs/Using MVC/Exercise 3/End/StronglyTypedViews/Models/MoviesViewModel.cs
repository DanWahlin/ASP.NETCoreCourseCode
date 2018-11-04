using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StronglyTypedViews.Models
{
    public class MoviesViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<MovieCategory> MovieCategories { get; set; }
    }
}
