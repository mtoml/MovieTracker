using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTracker.Model
{
    public class MovieCast
    {
        public int cast_id { get; set; }
        public string character { get; set; } //character name
        public string credit_id { get; set; }
        public string name { get; set; } //Actor name
        public int order { get; set; }
    }
}
