using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTracker.Model;
using System.Data;

namespace MovieTracker.DataAccess
{
    public class SQLServerAccess
    {
        //SQL Information
        private const string InitString = "user id=sa;password=IAMtehwinn4r;server=savinpwns.no-ip.org;" +
                                          "database=MovieTracker;connection timeout=30";

        
        public bool checkIfWatched(int movieID)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            bool isWatched;
            using (SqlConnection conn = new SqlConnection(InitString))
            {
                cmd = new SqlCommand("SELECT id FROM movie_list WHERE id='" + movieID + "'", conn);
                try
                {
                    conn.Open();

                    dr = cmd.ExecuteReader();
                    
                    if (dr.Read())
                    {
                        isWatched = true;
                    } else
                    {
                        isWatched = false;
                    }

                    conn.Close();
                    dr.Close();
                    cmd.Dispose();

                    return isWatched;
                } catch (SqlException sqe)
                {
                    Console.Write(sqe.Message);
                    return false;
                }
            }
        }

        public MovieDirectors getMovieDirector(int movieID)
        {
            MovieDirectors director = null;
            SqlDataReader dr = null;
            SqlCommand cmd = null;

            using (SqlConnection conn = new SqlConnection(InitString))
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("SELECT director_name FROM movie_directors WHERE movie_id = '" + movieID + "'", conn);

                    dr = cmd.ExecuteReader();

                    dr.Read();
                    director = new MovieDirectors();
                    director.director_name = dr["director_name"].ToString();


                    return director;
                } catch (SqlException sqe)
                {
                    Console.Write(sqe.Message);
                    return null;
                }
            }
        }

        public List<MovieCast> getMovieCast(int movieID)
        {
            List<MovieCast> cast_list = new List<MovieCast>();
            MovieCast cast = null;
            SqlDataReader dr = null;
            SqlCommand cmd = null;

            using (SqlConnection conn = new SqlConnection(InitString))
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("SELECT actor_name, character_name FROM movie_cast WHERE movie_id = '" + movieID +
                        "' ORDER BY credit_order", conn);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cast = new MovieCast();
                        cast.name = dr["actor_name"].ToString();
                        cast.character = dr["character_name"].ToString();

                        cast_list.Add(cast);
                    }

                    conn.Close();
                    dr.Close();
                    cmd.Dispose();

                    return cast_list;
                } catch (SqlException sqe) {
                    Console.Write(sqe.Message);
                    return null;
                }
            }
        }

        public WatchedMovie getWatchedMovie(int movieID)
        {
            WatchedMovie movie = new WatchedMovie(); ;
            SqlDataReader dr = null;
            SqlCommand cmd = null;

            using (SqlConnection conn = new SqlConnection(InitString))
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("SELECT title, tagline, release_status, release_date, revenue, budget, runtime, poster_path, personal_rating FROM movie_list " +
                        "WHERE id = " + movieID, conn);

                    dr = cmd.ExecuteReader();

                    if(dr.Read())
                    {
                        movie.Title = dr["title"].ToString();
                        movie.tagline = dr["tagline"].ToString();
                        movie.status = dr["release_status"].ToString();
                        movie.release_date = (DateTime?)dr["release_date"];
                        movie.Revenue = Convert.ToInt32(dr["revenue"]);
                        movie.Budget = Convert.ToInt32(dr["budget"]);
                        movie.Runtime = Convert.ToInt32(dr["runtime"]);
                        movie.poster_path = dr["poster_path"].ToString();
                        movie.personal_rating = Convert.ToInt32(dr["personal_rating"]);
                    }

                    conn.Close();
                    dr.Close();
                    cmd.Dispose();

                    return movie;
                } catch (SqlException sqe)
                {
                    Console.Write(sqe.Message);
                    return null;
                }
            }
        }

        public List<WatchedMovieModel> getAllWatchedMovies()
        {
            List<WatchedMovieModel> watchedMovies = new List<WatchedMovieModel>();
            WatchedMovieModel movie = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            using (SqlConnection conn = new SqlConnection(InitString))
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("select id, title, release_date, personal_rating from movie_list " +
                        "ORDER BY title", conn);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        movie = new WatchedMovieModel();

                        movie.movieID = Convert.ToInt32(dr["id"]);
                        movie.movieTitle = dr["title"].ToString();
                        movie.movieReleaseDate = (DateTime?)dr["release_date"];
                        movie.personal_rating = Convert.ToInt32(dr["personal_rating"]);

                        watchedMovies.Add(movie);
                    }

                    conn.Close();
                    dr.Close();
                    cmd.Dispose();

                    return watchedMovies;
                } catch (SqlException sqe)
                {
                    Console.Write(sqe.Message);
                    return null;
                }
            }
        }

        public void watchMovie (TmdbMovie movie, List<MovieCast> cast, List<MovieGenres> genre, MovieDirectors director, int rating)
        {
            SqlCommand cmd = null;
            using (SqlConnection conn = new SqlConnection(InitString))
            {
                try
                {
                    conn.Open();
                } catch (SqlException sqe)
                {
                    Console.Write(sqe.Message);
                    return;
                }

                using (SqlTransaction tr = conn.BeginTransaction())
                {
                    cmd = new SqlCommand("watchMovie", conn);
                    

                    //Load all parameters
                    cmd.Parameters.AddWithValue("@id", movie.id);
                    cmd.Parameters.AddWithValue("@title", movie.Title);
                    cmd.Parameters.AddWithValue("@release_status", movie.status);
                    cmd.Parameters.AddWithValue("@tagline", movie.tagline);
                    cmd.Parameters.AddWithValue("@overview", movie.Overview);
                    cmd.Parameters.AddWithValue("@backdrop_path", movie.backdrop_path);
                    cmd.Parameters.AddWithValue("@poster_path", movie.poster_path);
                    cmd.Parameters.AddWithValue("@adult", movie.adult);
                    cmd.Parameters.AddWithValue("@release_date", movie.release_date);
                    cmd.Parameters.AddWithValue("@revenue", movie.Revenue);
                    cmd.Parameters.AddWithValue("@budget", movie.Budget);
                    cmd.Parameters.AddWithValue("@runtime", movie.Runtime);
                    cmd.Parameters.AddWithValue("@rating", rating);

                    //Director stuff
                    cmd.Parameters.AddWithValue("@moviedirectorID", director.id);
                    cmd.Parameters.AddWithValue("@moviedirector", director.director_name);

                    //Create datatable to pass for List<MovieCast>
                    DataTable dt = new DataTable("movie_cast_list");
                    dt.Clear();
                    dt.Columns.Add("cast_id");
                    dt.Columns.Add("movie_id");
                    dt.Columns.Add("character_name");
                    dt.Columns.Add("credit_id");
                    dt.Columns.Add("actor_name");
                    dt.Columns.Add("credit_order");

                    for (int i = 0; i < cast.Count; i++)
                    {
                        DataRow row = dt.NewRow();
                        row["cast_id"] = cast[i].cast_id;
                        row["movie_id"] = movie.id;
                        row["character_name"] = cast[i].character;
                        row["credit_id"] = cast[i].credit_id;
                        row["actor_name"] = cast[i].name;
                        row["credit_order"] = cast[i].order;

                        dt.Rows.Add(row);
                    }
                    SqlParameter moviecast = cmd.Parameters.AddWithValue("@moviecast", dt);
                    moviecast.SqlDbType = SqlDbType.Structured;


                    //Create datatable to pass for List<MovieGenres>
                    dt = new DataTable("movie_genre_list");
                    dt.Clear();
                    dt.Columns.Add("id");
                    dt.Columns.Add("movie_id");
                    dt.Columns.Add("genre_name");

                    for (int i = 0; i < genre.Count; i++)
                    {
                        DataRow row = dt.NewRow();
                        row["id"] = genre[i].id;
                        row["movie_id"] = movie.id;
                        row["genre_name"] = genre[i].name;

                        dt.Rows.Add(row);
                    }
                    SqlParameter genres = cmd.Parameters.AddWithValue("@moviegenres", dt);
                    genres.SqlDbType = SqlDbType.Structured;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tr;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        tr.Commit();
                    } catch (SqlException sqe)
                    {
                        tr.Rollback();
                        Console.Write(sqe.Message);
                        return;
                    }

                    tr.Dispose();
                }
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}

