using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTracker.Model
{
    public class MovieModel
    {
        public int movieID { get; set; }
        public string movieTitle { get; set;}
        public DateTime? movieReleaseDate { get; set; }
    }
}
