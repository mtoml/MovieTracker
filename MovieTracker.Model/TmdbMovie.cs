using System;
using System.Collections.Generic;


namespace MovieTracker.Model
{
    public class TmdbMovie
    {
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string Title { get; set; }
        public string original_title { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string Overview { get; set; }
        public string Homepage { get; set; }

        public string backdrop_path { get; set; }
        public string poster_path { get; set; }

        public bool adult { get; set; }

        public List<MovieGenres> Genres { get; set; }

        public DateTime? release_date { get; set; }
        public long Revenue { get; set; }
        public long Budget { get; set; }
        public int Runtime { get; set; }
        
        public double Popularity { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }

        //public List<dynamic> production_companies { get; set; }
        //public List<dynamic> production_countries { get; set; }
        //public List<dynamic> spoken_languages { get; set; }

        
    }
}
