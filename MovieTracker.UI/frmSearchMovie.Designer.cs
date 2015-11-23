namespace MovieTracker.UI
{
    partial class frmSearchMovie
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
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.dgvMovieResults = new System.Windows.Forms.DataGridView();
            this.cmdView = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(35, 9);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(67, 13);
            this.lblMovieTitle.TabIndex = 0;
            this.lblMovieTitle.Text = "Search Title:";
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitleSearch.Location = new System.Drawing.Point(108, 7);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(140, 20);
            this.txtTitleSearch.TabIndex = 1;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(267, 4);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // dgvMovieResults
            // 
            this.dgvMovieResults.AllowUserToAddRows = false;
            this.dgvMovieResults.AllowUserToDeleteRows = false;
            this.dgvMovieResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieResults.Location = new System.Drawing.Point(12, 42);
            this.dgvMovieResults.MultiSelect = false;
            this.dgvMovieResults.Name = "dgvMovieResults";
            this.dgvMovieResults.ReadOnly = true;
            this.dgvMovieResults.Size = new System.Drawing.Size(349, 150);
            this.dgvMovieResults.TabIndex = 3;
            // 
            // cmdView
            // 
            this.cmdView.Location = new System.Drawing.Point(12, 198);
            this.cmdView.Name = "cmdView";
            this.cmdView.Size = new System.Drawing.Size(75, 23);
            this.cmdView.TabIndex = 4;
            this.cmdView.Text = "View Details";
            this.cmdView.UseVisualStyleBackColor = true;
            this.cmdView.Click += new System.EventHandler(this.cmdView_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(286, 198);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmSearchMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 229);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdView);
            this.Controls.Add(this.dgvMovieResults);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtTitleSearch);
            this.Controls.Add(this.lblMovieTitle);
            this.Name = "frmSearchMovie";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.DataGridView dgvMovieResults;
        private System.Windows.Forms.Button cmdView;
        private System.Windows.Forms.Button cmdCancel;
    }
}