using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MovieTracker.DataAccess;
using MovieTracker.Model;

namespace MovieTracker.UI
{
    public partial class frmWatchedMovies : Form
    {
        public frmWatchedMovies()
        {
            InitializeComponent();
        }

        private void cmdQuery_Click(object sender, EventArgs e)
        {
            SQLServerAccess sqa = new SQLServerAccess();

            dgvMovieResults.DataSource = null;
            dgvMovieResults.Rows.Clear();
            dgvMovieResults.Columns.Clear();

            List<WatchedMovieModel> movielist = new List<WatchedMovieModel>();
            movielist = sqa.getAllWatchedMovies();

            if (movielist != null)
            {
                dgvMovieResults.Columns.Add("clmMovieID", "Movie ID");
                dgvMovieResults.Columns.Add("clmMovieTitle", "Movie Title");
                dgvMovieResults.Columns.Add("clmReleaseDate", "Release Date");
                dgvMovieResults.Columns.Add("clmRating", "Rating");


                foreach (WatchedMovieModel m in movielist){    
                    string[] row = new string[] { m.movieID.ToString(), m.movieTitle, DateTime.Parse(m.movieReleaseDate.ToString()).ToString("yyyy-MM-dd"), m.personal_rating.ToString() };
                    dgvMovieResults.Rows.Add(row);
                }
                

                dgvMovieResults.Refresh();
            } else
            {
                dgvMovieResults.Columns.Add("clmError", "Error Message");
                dgvMovieResults.Rows.Add();
                dgvMovieResults.Rows[0].Cells[0].Value = "Error";
                Console.WriteLine("Returned null");
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
