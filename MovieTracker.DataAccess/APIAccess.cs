using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

using MovieTracker.Model;
using System.Net;

namespace MovieTracker.DataAccess
{
    public class APIAccess
    {
        private static string APIKEY = "17c195f26ddf60ff8fd339f8091ddc7d";

        public async Task<MovieDirectors> getMovieDirector(int id)
        {
            Uri baseAddress = new Uri("http://api.themoviedb.org/3/");
            MovieDirectors director = new MovieDirectors();

            using (HttpClient httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

                using (HttpResponseMessage response = await httpClient.GetAsync("movie/" + id + "/credits?api_key=" + APIKEY))
                {
                    if (response.StatusCode == (HttpStatusCode)200)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        dynamic res = JsonConvert.DeserializeObject(responseData);

                        foreach (dynamic i in res["crew"])
                        {
                            if (i["job"] == "Director")
                            {
                                director.id = i["id"];
                                director.director_name = i["name"];
                            }
                        }

                        return director;
                    }
                }
            }

            return null;
        }

        public async Task<List<MovieCast>> getMovieCredits(int id)
        {
            Uri baseAddress = new Uri("http://api.themoviedb.org/3/");
            List<MovieCast> creditList = new List<MovieCast>();
            MovieCast cast = null;

            using (HttpClient httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

                using (HttpResponseMessage response = await httpClient.GetAsync("movie/" + id + "/credits?api_key=" + APIKEY))
                {
                    if (response.StatusCode == (HttpStatusCode)200)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        dynamic res = JsonConvert.DeserializeObject(responseData);

                        foreach (dynamic i in res["cast"])
                        {
                            cast = new MovieCast();

                            cast.cast_id = i["cast_id"];
                            cast.character = i["character"];
                            cast.credit_id = i["credit_id"];
                            cast.name = i["name"];
                            cast.order = i["order"];

                            creditList.Add(cast);
                        }

                        return creditList;
                    }
                }
            }

            return creditList;
        } 

        public async Task<TmdbMovie> fullMovieDetails(int id)
        {
            Uri baseAddress = new Uri("http://api.themoviedb.org/3/");
            TmdbMovie Movie = null;

            using (HttpClient httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

                using (HttpResponseMessage response = await httpClient.GetAsync("movie/" + id + "?api_key=" + APIKEY))
                {
                    if (response.StatusCode == (HttpStatusCode)200)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        Movie = JsonConvert.DeserializeObject<TmdbMovie>(responseData);
                        return Movie;
                    } else
                    {
                        MessageBox.Show("Error:" + response.StatusCode.ToString() + '\n' + response.Headers.ToString());
                        return null;
                    }
                        
                }
            }
        }

        public async Task<List<MovieModel>> SearchMovieTitle(string title)
        {
            Uri baseAddress = new Uri("http://api.themoviedb.org/3/");
            List<MovieModel> movieList = new List<MovieModel>();
            MovieModel movies = null;

            string movieTitle = cleanMovieTitle(title);

            using (HttpClient httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");

                using (HttpResponseMessage response = await httpClient.GetAsync("search/movie?api_key=" + APIKEY + "&query=" + movieTitle))
                {
                    if (response.StatusCode == (HttpStatusCode)200)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        dynamic res = JsonConvert.DeserializeObject(responseData);

                        foreach (dynamic i in res["results"])
                        {
                            movies = new MovieModel();
                            movies.movieID = i["id"];
                            movies.movieTitle = i["title"];
                            if (i["release_date"] != "")
                            {
                                movies.movieReleaseDate = i["release_date"];
                            }
                            

                            movieList.Add(movies);
                        }

                        return movieList;
                    } else
                    {
                        MessageBox.Show("Error:" + response.StatusCode.ToString() + '\n' + response.Headers.ToString());
                        return null;
                    }
                }
            }
        }

        private string cleanMovieTitle(string title)
        {
            string newTitle = title.Replace(' ', '+');

            return newTitle;
        }
    }
}
