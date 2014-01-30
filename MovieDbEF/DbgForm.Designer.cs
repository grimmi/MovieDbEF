namespace MovieDbEF
{
    partial class DbgForm
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
            this.tViewPersons = new System.Windows.Forms.TreeView();
            this.tViewMovies = new System.Windows.Forms.TreeView();
            this.txtBoxInfo = new System.Windows.Forms.TextBox();
            this.tbMovieTitle = new System.Windows.Forms.TextBox();
            this.tbMovieActors = new System.Windows.Forms.TextBox();
            this.tbMovieDirectors = new System.Windows.Forms.TextBox();
            this.dtpMovieYear = new System.Windows.Forms.DateTimePicker();
            this.nupMovieDuration = new System.Windows.Forms.NumericUpDown();
            this.btnChoseActors = new System.Windows.Forms.Button();
            this.btnChoseDirectors = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupMovieDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // tViewPersons
            // 
            this.tViewPersons.Location = new System.Drawing.Point(13, 13);
            this.tViewPersons.Name = "tViewPersons";
            this.tViewPersons.Size = new System.Drawing.Size(231, 351);
            this.tViewPersons.TabIndex = 0;
            this.tViewPersons.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tViewPersons_NodeMouseClick);
            // 
            // tViewMovies
            // 
            this.tViewMovies.Location = new System.Drawing.Point(250, 13);
            this.tViewMovies.Name = "tViewMovies";
            this.tViewMovies.Size = new System.Drawing.Size(231, 351);
            this.tViewMovies.TabIndex = 1;
            this.tViewMovies.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tViewPersons_NodeMouseClick);
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.Location = new System.Drawing.Point(488, 13);
            this.txtBoxInfo.Multiline = true;
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.ReadOnly = true;
            this.txtBoxInfo.Size = new System.Drawing.Size(294, 351);
            this.txtBoxInfo.TabIndex = 2;
            // 
            // tbMovieTitle
            // 
            this.tbMovieTitle.Location = new System.Drawing.Point(789, 13);
            this.tbMovieTitle.Name = "tbMovieTitle";
            this.tbMovieTitle.Size = new System.Drawing.Size(207, 20);
            this.tbMovieTitle.TabIndex = 3;
            // 
            // tbMovieActors
            // 
            this.tbMovieActors.Location = new System.Drawing.Point(789, 40);
            this.tbMovieActors.Name = "tbMovieActors";
            this.tbMovieActors.ReadOnly = true;
            this.tbMovieActors.Size = new System.Drawing.Size(154, 20);
            this.tbMovieActors.TabIndex = 4;
            // 
            // tbMovieDirectors
            // 
            this.tbMovieDirectors.Location = new System.Drawing.Point(789, 66);
            this.tbMovieDirectors.Name = "tbMovieDirectors";
            this.tbMovieDirectors.ReadOnly = true;
            this.tbMovieDirectors.Size = new System.Drawing.Size(154, 20);
            this.tbMovieDirectors.TabIndex = 5;
            // 
            // dtpMovieYear
            // 
            this.dtpMovieYear.CustomFormat = "yyyy";
            this.dtpMovieYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMovieYear.Location = new System.Drawing.Point(789, 93);
            this.dtpMovieYear.Name = "dtpMovieYear";
            this.dtpMovieYear.ShowUpDown = true;
            this.dtpMovieYear.Size = new System.Drawing.Size(79, 20);
            this.dtpMovieYear.TabIndex = 6;
            // 
            // nupMovieDuration
            // 
            this.nupMovieDuration.Location = new System.Drawing.Point(874, 92);
            this.nupMovieDuration.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupMovieDuration.Name = "nupMovieDuration";
            this.nupMovieDuration.Size = new System.Drawing.Size(69, 20);
            this.nupMovieDuration.TabIndex = 7;
            this.nupMovieDuration.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnChoseActors
            // 
            this.btnChoseActors.Location = new System.Drawing.Point(950, 40);
            this.btnChoseActors.Name = "btnChoseActors";
            this.btnChoseActors.Size = new System.Drawing.Size(46, 20);
            this.btnChoseActors.TabIndex = 8;
            this.btnChoseActors.Text = "...";
            this.btnChoseActors.UseVisualStyleBackColor = true;
            this.btnChoseActors.Click += new System.EventHandler(this.btnChoseActors_Click);
            // 
            // btnChoseDirectors
            // 
            this.btnChoseDirectors.Location = new System.Drawing.Point(950, 66);
            this.btnChoseDirectors.Name = "btnChoseDirectors";
            this.btnChoseDirectors.Size = new System.Drawing.Size(46, 20);
            this.btnChoseDirectors.TabIndex = 9;
            this.btnChoseDirectors.Text = "...";
            this.btnChoseDirectors.UseVisualStyleBackColor = true;
            this.btnChoseDirectors.Click += new System.EventHandler(this.btnChoseDirectors_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(789, 120);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(207, 23);
            this.btnAddMovie.TabIndex = 10;
            this.btnAddMovie.Text = "Neuen Film anlegen";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // DbgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 376);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnChoseDirectors);
            this.Controls.Add(this.btnChoseActors);
            this.Controls.Add(this.nupMovieDuration);
            this.Controls.Add(this.dtpMovieYear);
            this.Controls.Add(this.tbMovieDirectors);
            this.Controls.Add(this.tbMovieActors);
            this.Controls.Add(this.tbMovieTitle);
            this.Controls.Add(this.txtBoxInfo);
            this.Controls.Add(this.tViewMovies);
            this.Controls.Add(this.tViewPersons);
            this.Name = "DbgForm";
            this.Text = "DbgForm";
            ((System.ComponentModel.ISupportInitialize)(this.nupMovieDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tViewPersons;
        private System.Windows.Forms.TreeView tViewMovies;
        private System.Windows.Forms.TextBox txtBoxInfo;
        private System.Windows.Forms.TextBox tbMovieTitle;
        private System.Windows.Forms.TextBox tbMovieActors;
        private System.Windows.Forms.TextBox tbMovieDirectors;
        private System.Windows.Forms.DateTimePicker dtpMovieYear;
        private System.Windows.Forms.NumericUpDown nupMovieDuration;
        private System.Windows.Forms.Button btnChoseActors;
        private System.Windows.Forms.Button btnChoseDirectors;
        private System.Windows.Forms.Button btnAddMovie;
    }
}