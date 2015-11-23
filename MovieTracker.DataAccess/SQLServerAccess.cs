using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTracker.Model;

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
            using (SqlConnection conn = new SqlConnection(InitString))
            {
                try
                {
                    conn.Open();

                    conn.Close();
                }
                catch (SqlException sqe)
                {
                    Console.Write(sqe.Message);
                }
            }
        }
    }
}
