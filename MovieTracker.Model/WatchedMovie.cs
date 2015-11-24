using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTracker.Model
{
    public class WatchedMovie : TmdbMovie
    {
        public int personal_rating { get; set; }
    }
}
