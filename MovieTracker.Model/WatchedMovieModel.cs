using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTracker.Model
{
    public class WatchedMovieModel : TmdbMovie
    {
        public int personalMovieRating { get; set; } // personal rating given in app  
    }
}
