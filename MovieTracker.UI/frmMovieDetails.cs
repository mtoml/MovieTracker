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
    public partial class frmMovieDetails : Form
    {
        //External data access
        private APIAccess API_INIT;
        private SQLServerAccess sqa;

        private List<MovieCast> cast;
        private static string MovieURLPrefix = "http://image.tmdb.org/t/p/";

        private string MoviePosterURL;

        public int movieID;
        public dynamic movie;
        

        public frmMovieDetails()
        {
            InitializeComponent();
        }

        private async void frmMovieDetails_Load(object sender, EventArgs e)
        {
            lblLoading.Visible = true;

            sqa = new SQLServerAccess();
            if (sqa.checkIfWatched(movieID))
            {
                movie = new WatchedMovie();
                movie = sqa.getWatchedMovie(movieID);
                getMovieDetails(movieID);
                cmdWatched.Enabled = false;
                cmdWatched.Text = "Watched";
                chklbStarRating.SetItemChecked(movie.personal_rating - 1, true);
            } else
            {
                API_INIT = new APIAccess(); 
                movie = new TmdbMovie();
                movie = await API_INIT.fullMovieDetails(movieID);
                await getMovieDetails();
            }

            MoviePosterURL = movie.poster_path;

            lblTitle.Text = movie.Title;
            lblTagLine.Text = movie.tagline;
            
            lblStatusActual.Text = movie.status;

            if (movie.status == "Released")
            {
                lblStatusActual.ForeColor = Color.Green;
            } else
            {
                lblStatusActual.ForeColor = Color.Red;
            }

            lblReleaseDateActual.Text = movie.release_date.ToString();
            lblRevenueActual.Text = "$" + string.Format("{0:N}", movie.Revenue);
            lblBudgetActual.Text = "$" + string.Format("{0:N}", movie.Budget);
            lblRuntimeActual.Text = movie.Runtime.ToString() + " mins";

            picMoviePoster.ImageLocation = MovieURLPrefix + "w500" + MoviePosterURL;

            

            lblLoading.Visible = false;
        }

        private void getMovieDetails(int movieID)
        {
            cast = new List<MovieCast>();
            sqa = new SQLServerAccess();

            cast = sqa.getMovieCast(this.movieID);

            foreach (MovieCast m in cast)
            {
                string[] row = new string[] { m.name, m.character };
                dgvMovieCredits.Rows.Add(row);
            }
        }

        private async Task getMovieDetails()
        {
            
            cast = new List<MovieCast>();

            API_INIT = new APIAccess();

            cast = await API_INIT.getMovieCredits(movieID);

            foreach (MovieCast m in cast)
            {
                string[] row = new string[] { m.name, m.character };
                dgvMovieCredits.Rows.Add(row);
            }
        }


        private void cmdWatched_Click(object sender, EventArgs e)
        {
            int rating = 0;
            if (chklbStarRating.CheckedItems.Count != 0)
            {
                foreach(char s in chklbStarRating.CheckedItems[0].ToString()) {
                    rating++;
                }
            } else
            {
                MessageBox.Show("Please give a movie rating", "Error!");
                return;
            }

            lblLoading.Visible = true;
            lblLoading.Text = "SAVING";
            sqa = new SQLServerAccess();

            sqa.watchMovie(movie, cast, movie.Genres, rating);
            cmdWatched.Enabled = false;
            lblLoading.Visible = false;
            lblLoading.Text = "LOADING";
        }
    }
}
