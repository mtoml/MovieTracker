namespace MovieTracker.UI
{
    partial class frmWatchedMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdView = new System.Windows.Forms.Button();
            this.dgvMovieResults = new System.Windows.Forms.DataGridView();
            this.cmdQuery = new System.Windows.Forms.Button();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(493, 470);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdView
            // 
            this.cmdView.Enabled = false;
            this.cmdView.Location = new System.Drawing.Point(12, 470);
            this.cmdView.Name = "cmdView";
            this.cmdView.Size = new System.Drawing.Size(75, 23);
            this.cmdView.TabIndex = 10;
            this.cmdView.Text = "View Details";
            this.cmdView.UseVisualStyleBackColor = true;
            // 
            // dgvMovieResults
            // 
            this.dgvMovieResults.AllowUserToAddRows = false;
            this.dgvMovieResults.AllowUserToDeleteRows = false;
            this.dgvMovieResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieResults.Location = new System.Drawing.Point(12, 44);
            this.dgvMovieResults.MultiSelect = false;
            this.dgvMovieResults.Name = "dgvMovieResults";
            this.dgvMovieResults.ReadOnly = true;
            this.dgvMovieResults.Size = new System.Drawing.Size(556, 420);
            this.dgvMovieResults.TabIndex = 9;
            // 
            // cmdQuery
            // 
            this.cmdQuery.Location = new System.Drawing.Point(335, 12);
            this.cmdQuery.Name = "cmdQuery";
            this.cmdQuery.Size = new System.Drawing.Size(147, 23);
            this.cmdQuery.TabIndex = 8;
            this.cmdQuery.Text = "Query";
            this.cmdQuery.UseVisualStyleBackColor = true;
            this.cmdQuery.Click += new System.EventHandler(this.cmdQuery_Click);
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitleSearch.Enabled = false;
            this.txtTitleSearch.Location = new System.Drawing.Point(176, 15);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(140, 20);
            this.txtTitleSearch.TabIndex = 7;
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(103, 17);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(67, 13);
            this.lblMovieTitle.TabIndex = 6;
            this.lblMovieTitle.Text = "Search Title:";
            // 
            // frmWatchedMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 505);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdView);
            this.Controls.Add(this.dgvMovieResults);
            this.Controls.Add(this.cmdQuery);
            this.Controls.Add(this.txtTitleSearch);
            this.Controls.Add(this.lblMovieTitle);
            this.Name = "frmWatchedMovies";
            this.Text = "Watched Movie List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdView;
        private System.Windows.Forms.DataGridView dgvMovieResults;
        private System.Windows.Forms.Button cmdQuery;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Label lblMovieTitle;
    }
}