using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDemo.Models
{
    public class MoviesRepository
    {
        public List<Movie> List()
        {
            return new List<Movie>
            {
                new Movie { Id=1, Title="Star Wars", Director="George Lucas"},
                new Movie { Id=1, Title="Lord of the Rings", Director="Peter Jackson"}
            };
        }
    }
}
