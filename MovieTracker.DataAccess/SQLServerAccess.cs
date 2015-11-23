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
            using (SqlConnection conn = new SqlConnection(InitString))
            {
                cmd = new SqlCommand("SELECT MovieRating FROM movies WHERE MovieDBID='" + movieID + "'", conn);
                try
                {
                    conn.Open();

                    dr = cmd.ExecuteReader();
                    dr.Read();

                    conn.Close();
                    dr.Close();
                    cmd.Dispose();

                    if ((bool)dr["isWatched"])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } catch (SqlException sqe)
                {
                    Console.Write(sqe.Message);
                    return false;
                }
            }
        }

        public List<WatchedMovieModel> getAllWatchedMovies()
        {
            List<WatchedMovieModel> watchedMovies = null;

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

        public void watchMovie (int movieID, int movieRating)
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
