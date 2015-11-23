using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MovieTracker.Model;
using MovieTracker.DataAccess;

namespace MovieTracker.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchMovie searchForm = new frmSearchMovie();
            searchForm.MdiParent = this;
            searchForm.Show();
        }
    }
}
