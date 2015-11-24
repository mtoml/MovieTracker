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

        public WatchedMovie getWatchedMovie(int movieID)
        {
            return null;
        }

        public List<TmdbMovie> getAllWatchedMovies()
        {
            List<TmdbMovie> watchedMovies = null;

            using (SqlConnection conn = new SqlConnection(InitString))
            {
                try
                {
                    conn.Open();

                    conn.Close();
                } catch (SqlException sqe)
                {
                    Console.Write(sqe.Message);
                }
            }


                return watchedMovies;
        }

        public void watchMovie (TmdbMovie movie, List<MovieCast> cast, List<MovieGenres> genre, int rating)
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

