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
    public partial class frmSearchMovie : Form
    {
        APIAccess API_INIT;

        public frmSearchMovie()
        {
            InitializeComponent();
        }

        private async void cmdSearch_Click(object sender, EventArgs e)
        {
            dgvMovieResults.DataSource = null;
            dgvMovieResults.Rows.Clear();
            dgvMovieResults.Columns.Clear();

            if (txtTitleSearch.Text == "")
            {
                MessageBox.Show("Please enter a movie title", "Error");
                return;
            }
            List<MovieModel> movieTitles = new List<MovieModel>();
            API_INIT = new APIAccess();
            //try
            //{
            movieTitles = await API_INIT.SearchMovieTitle(txtTitleSearch.Text);
            //} catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            
            if (movieTitles != null)
            {
                dgvMovieResults.DataSource = movieTitles;
                dgvMovieResults.Columns[0].HeaderText = "Movie ID";
                dgvMovieResults.Columns[1].HeaderText = "Movie Title";
                dgvMovieResults.Columns[2].HeaderText = "Release Date";

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

        private async void cmdView_Click(object sender, EventArgs e)
        {
            if (dgvMovieResults.SelectedRows.Count == 1 )
            {
                frmMovieDetails movieDetailsForm = new frmMovieDetails();
                movieDetailsForm.MdiParent = this.MdiParent;

                API_INIT = new APIAccess();
                TmdbMovie movieDetails = null;


                int selectedRowIndex = dgvMovieResults.CurrentCell.RowIndex;
                movieDetails = await API_INIT.fullMovieDetails(Convert.ToInt32(dgvMovieResults.Rows[selectedRowIndex].Cells[0].Value));

                movieDetailsForm.Controls["lblTitle"].Text = movieDetails.Title;
                movieDetailsForm.Controls["lblTagLine"].Text = movieDetails.tagline;

                movieDetailsForm.Controls["lblStatusActual"].Text = movieDetails.status;
                if (movieDetails.status == "Released")
                {
                    movieDetailsForm.Controls["lblStatusActual"].ForeColor = Color.Green;
                } else
                {
                    movieDetailsForm.Controls["lblStatusActual"].ForeColor = Color.Red;
                }
                movieDetailsForm.Controls["lblReleaseDateActual"].Text = movieDetails.release_date.ToString();
                movieDetailsForm.Controls["lblRevenueActual"].Text = "$" + string.Format("{0:N}", movieDetails.Revenue);
                movieDetailsForm.Controls["lblBudgetActual"].Text = "$" + string.Format("{0:N}", movieDetails.Budget);
                movieDetailsForm.Controls["lblRuntimeActual"].Text = movieDetails.Runtime.ToString() + " mins";


                movieDetailsForm.MoviePosterURL = movieDetails.poster_path;
                movieDetailsForm.movieID = movieDetails.id;

                movieDetailsForm.Show();
            } else
            {
                MessageBox.Show("Please select only one title!", "Error");
                return;
            }
        }
    }
}
