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
        APIAccess API_INIT;

        private static string MovieURLPrefix = "http://image.tmdb.org/t/p/";

        public string MoviePosterURL;
        public int movieID;


        public frmMovieDetails()
        {
            InitializeComponent();
        }

        private async void frmMovieDetails_Load(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            await getMovieDetails();
            lblLoading.Visible = false;
        }

        private async Task getMovieDetails()
        {
            picMoviePoster.ImageLocation = MovieURLPrefix + "w500" + MoviePosterURL;
            List<MovieCast> cast = new List<MovieCast>();

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

        }
    }
}
