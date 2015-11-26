namespace MovieTracker.UI
{
    partial class frmMovieDetails
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTagLine = new System.Windows.Forms.Label();
            this.picMoviePoster = new System.Windows.Forms.PictureBox();
            this.dgvMovieCredits = new System.Windows.Forms.DataGridView();
            this.clmActor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblReleaseStatus = new System.Windows.Forms.Label();
            this.cmdWatched = new System.Windows.Forms.Button();
            this.chklbStarRating = new System.Windows.Forms.CheckedListBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblStatusActual = new System.Windows.Forms.Label();
            this.lblReleaseDateActual = new System.Windows.Forms.Label();
            this.lblRevenueActual = new System.Windows.Forms.Label();
            this.lblBudgetActual = new System.Windows.Forms.Label();
            this.lblRuntimeActual = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMoviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.MaximumSize = new System.Drawing.Size(730, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Movie Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagLine
            // 
            this.lblTagLine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTagLine.AutoSize = true;
            this.lblTagLine.BackColor = System.Drawing.Color.Transparent;
            this.lblTagLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagLine.Location = new System.Drawing.Point(12, 91);
            this.lblTagLine.MaximumSize = new System.Drawing.Size(730, 0);
            this.lblTagLine.Name = "lblTagLine";
            this.lblTagLine.Size = new System.Drawing.Size(82, 20);
            this.lblTagLine.TabIndex = 2;
            this.lblTagLine.Text = "TAG LINE";
            this.lblTagLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMoviePoster
            // 
            this.picMoviePoster.Location = new System.Drawing.Point(433, 163);
            this.picMoviePoster.Name = "picMoviePoster";
            this.picMoviePoster.Size = new System.Drawing.Size(269, 342);
            this.picMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMoviePoster.TabIndex = 3;
            this.picMoviePoster.TabStop = false;
            // 
            // dgvMovieCredits
            // 
            this.dgvMovieCredits.AllowUserToAddRows = false;
            this.dgvMovieCredits.AllowUserToDeleteRows = false;
            this.dgvMovieCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieCredits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmActor,
            this.clmCharacter});
            this.dgvMovieCredits.Location = new System.Drawing.Point(16, 284);
            this.dgvMovieCredits.Name = "dgvMovieCredits";
            this.dgvMovieCredits.ReadOnly = true;
            this.dgvMovieCredits.Size = new System.Drawing.Size(411, 221);
            this.dgvMovieCredits.TabIndex = 4;
            // 
            // clmActor
            // 
            this.clmActor.HeaderText = "Actor";
            this.clmActor.Name = "clmActor";
            this.clmActor.ReadOnly = true;
            this.clmActor.Width = 200;
            // 
            // clmCharacter
            // 
            this.clmCharacter.HeaderText = "Character";
            this.clmCharacter.Name = "clmCharacter";
            this.clmCharacter.ReadOnly = true;
            this.clmCharacter.Width = 200;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(16, 185);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(75, 13);
            this.lblReleaseDate.TabIndex = 5;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // lblReleaseStatus
            // 
            this.lblReleaseStatus.AutoSize = true;
            this.lblReleaseStatus.Location = new System.Drawing.Point(16, 163);
            this.lblReleaseStatus.Name = "lblReleaseStatus";
            this.lblReleaseStatus.Size = new System.Drawing.Size(40, 13);
            this.lblReleaseStatus.TabIndex = 6;
            this.lblReleaseStatus.Text = "Status:";
            // 
            // cmdWatched
            // 
            this.cmdWatched.Location = new System.Drawing.Point(329, 251);
            this.cmdWatched.Name = "cmdWatched";
            this.cmdWatched.Size = new System.Drawing.Size(98, 27);
            this.cmdWatched.TabIndex = 7;
            this.cmdWatched.Text = "Watched?";
            this.cmdWatched.UseVisualStyleBackColor = true;
            this.cmdWatched.Click += new System.EventHandler(this.cmdWatched_Click);
            // 
            // chklbStarRating
            // 
            this.chklbStarRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklbStarRating.FormattingEnabled = true;
            this.chklbStarRating.Items.AddRange(new object[] {
            "*",
            "**",
            "***",
            "****",
            "*****"});
            this.chklbStarRating.Location = new System.Drawing.Point(329, 168);
            this.chklbStarRating.Name = "chklbStarRating";
            this.chklbStarRating.Size = new System.Drawing.Size(48, 77);
            this.chklbStarRating.TabIndex = 8;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(383, 168);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 9;
            this.lblRating.Text = "Rating";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(16, 207);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(54, 13);
            this.lblRevenue.TabIndex = 11;
            this.lblRevenue.Text = "Revenue:";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(16, 229);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(44, 13);
            this.lblBudget.TabIndex = 10;
            this.lblBudget.Text = "Budget:";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(16, 251);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(49, 13);
            this.lblRuntime.TabIndex = 12;
            this.lblRuntime.Text = "Runtime:";
            // 
            // lblStatusActual
            // 
            this.lblStatusActual.AutoSize = true;
            this.lblStatusActual.Location = new System.Drawing.Point(115, 163);
            this.lblStatusActual.Name = "lblStatusActual";
            this.lblStatusActual.Size = new System.Drawing.Size(0, 13);
            this.lblStatusActual.TabIndex = 13;
            // 
            // lblReleaseDateActual
            // 
            this.lblReleaseDateActual.AutoSize = true;
            this.lblReleaseDateActual.Location = new System.Drawing.Point(115, 185);
            this.lblReleaseDateActual.Name = "lblReleaseDateActual";
            this.lblReleaseDateActual.Size = new System.Drawing.Size(0, 13);
            this.lblReleaseDateActual.TabIndex = 14;
            // 
            // lblRevenueActual
            // 
            this.lblRevenueActual.AutoSize = true;
            this.lblRevenueActual.Location = new System.Drawing.Point(115, 207);
            this.lblRevenueActual.Name = "lblRevenueActual";
            this.lblRevenueActual.Size = new System.Drawing.Size(0, 13);
            this.lblRevenueActual.TabIndex = 15;
            // 
            // lblBudgetActual
            // 
            this.lblBudgetActual.AutoSize = true;
            this.lblBudgetActual.Location = new System.Drawing.Point(115, 229);
            this.lblBudgetActual.Name = "lblBudgetActual";
            this.lblBudgetActual.Size = new System.Drawing.Size(0, 13);
            this.lblBudgetActual.TabIndex = 16;
            // 
            // lblRuntimeActual
            // 
            this.lblRuntimeActual.AutoSize = true;
            this.lblRuntimeActual.Location = new System.Drawing.Point(115, 251);
            this.lblRuntimeActual.Name = "lblRuntimeActual";
            this.lblRuntimeActual.Size = new System.Drawing.Size(0, 13);
            this.lblRuntimeActual.TabIndex = 17;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Red;
            this.lblLoading.Location = new System.Drawing.Point(273, 183);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(185, 42);
            this.lblLoading.TabIndex = 19;
            this.lblLoading.Text = "LOADING";
            this.lblLoading.Visible = false;
            // 
            // frmMovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 517);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblRuntimeActual);
            this.Controls.Add(this.lblBudgetActual);
            this.Controls.Add(this.lblRevenueActual);
            this.Controls.Add(this.lblReleaseDateActual);
            this.Controls.Add(this.lblStatusActual);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.chklbStarRating);
            this.Controls.Add(this.cmdWatched);
            this.Controls.Add(this.lblReleaseStatus);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.dgvMovieCredits);
            this.Controls.Add(this.picMoviePoster);
            this.Controls.Add(this.lblTagLine);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmMovieDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Details";
            this.Load += new System.EventHandler(this.frmMovieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMoviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTagLine;
        private System.Windows.Forms.PictureBox picMoviePoster;
        private System.Windows.Forms.DataGridView dgvMovieCredits;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblReleaseStatus;
        private System.Windows.Forms.Button cmdWatched;
        private System.Windows.Forms.CheckedListBox chklbStarRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblStatusActual;
        private System.Windows.Forms.Label lblReleaseDateActual;
        private System.Windows.Forms.Label lblRevenueActual;
        private System.Windows.Forms.Label lblBudgetActual;
        private System.Windows.Forms.Label lblRuntimeActual;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCharacter;
    }
}