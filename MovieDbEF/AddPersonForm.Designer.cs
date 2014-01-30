namespace MovieDbEF
{
    partial class AddPersonForm
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbMoviesAsActor = new System.Windows.Forms.TextBox();
            this.tbMoviesAsDirector = new System.Windows.Forms.TextBox();
            this.btnChoseMoviesAsActor = new System.Windows.Forms.Button();
            this.btnChoseMoviesAsDirector = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(13, 13);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(13, 39);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(13, 66);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 2;
            // 
            // tbMoviesAsActor
            // 
            this.tbMoviesAsActor.Location = new System.Drawing.Point(13, 93);
            this.tbMoviesAsActor.Name = "tbMoviesAsActor";
            this.tbMoviesAsActor.ReadOnly = true;
            this.tbMoviesAsActor.Size = new System.Drawing.Size(133, 20);
            this.tbMoviesAsActor.TabIndex = 3;
            // 
            // tbMoviesAsDirector
            // 
            this.tbMoviesAsDirector.Location = new System.Drawing.Point(13, 119);
            this.tbMoviesAsDirector.Name = "tbMoviesAsDirector";
            this.tbMoviesAsDirector.ReadOnly = true;
            this.tbMoviesAsDirector.Size = new System.Drawing.Size(133, 20);
            this.tbMoviesAsDirector.TabIndex = 4;
            // 
            // btnChoseMoviesAsActor
            // 
            this.btnChoseMoviesAsActor.Location = new System.Drawing.Point(152, 91);
            this.btnChoseMoviesAsActor.Name = "btnChoseMoviesAsActor";
            this.btnChoseMoviesAsActor.Size = new System.Drawing.Size(60, 23);
            this.btnChoseMoviesAsActor.TabIndex = 5;
            this.btnChoseMoviesAsActor.Text = "...";
            this.btnChoseMoviesAsActor.UseVisualStyleBackColor = true;
            this.btnChoseMoviesAsActor.Click += new System.EventHandler(this.btnChoseMoviesAsActor_Click);
            // 
            // btnChoseMoviesAsDirector
            // 
            this.btnChoseMoviesAsDirector.Location = new System.Drawing.Point(152, 117);
            this.btnChoseMoviesAsDirector.Name = "btnChoseMoviesAsDirector";
            this.btnChoseMoviesAsDirector.Size = new System.Drawing.Size(60, 23);
            this.btnChoseMoviesAsDirector.TabIndex = 6;
            this.btnChoseMoviesAsDirector.Text = "...";
            this.btnChoseMoviesAsDirector.UseVisualStyleBackColor = true;
            this.btnChoseMoviesAsDirector.Click += new System.EventHandler(this.btnChoseMoviesAsDirector_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Übernehmen";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(121, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Abbruch";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 181);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChoseMoviesAsDirector);
            this.Controls.Add(this.btnChoseMoviesAsActor);
            this.Controls.Add(this.tbMoviesAsDirector);
            this.Controls.Add(this.tbMoviesAsActor);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPersonForm";
            this.Text = "AddPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox tbMoviesAsActor;
        private System.Windows.Forms.TextBox tbMoviesAsDirector;
        private System.Windows.Forms.Button btnChoseMoviesAsActor;
        private System.Windows.Forms.Button btnChoseMoviesAsDirector;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}