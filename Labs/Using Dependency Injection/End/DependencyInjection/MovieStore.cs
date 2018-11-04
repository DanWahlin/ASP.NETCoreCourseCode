using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class MovieStore : IMovieStore
    {
        int _movieCount;

        public MovieStore()
        {
            Debug.WriteLine("in");
        }

        public int AddMovie()
        {
            return _movieCount++;
        }
    }
}
