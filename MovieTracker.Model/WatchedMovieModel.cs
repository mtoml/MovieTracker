using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTracker.Model
{
    public class WatchedMovieModel : TmdbMovie
    {
        public bool isWatched { get; set; } // true is results are returned, false if not. this does not need to be stored in db
        public int personalMovieRating { get; set; } // personal rating given in app  
    }
}
