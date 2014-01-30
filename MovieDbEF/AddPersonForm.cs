using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDbEF
{
    public partial class AddPersonForm : Form
    {
        private IEnumerable<Movie> actorMovies;
        private IEnumerable<Movie> directorMovies;
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void btnChoseMoviesAsActor_Click(object sender, EventArgs e)
        {
            SelectMoviesForm smForm = new SelectMoviesForm();
            if (smForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                actorMovies = smForm.SelectedMovies;
                tbMoviesAsActor.Text = String.Join(",", actorMovies);
            }
        }

        private void btnChoseMoviesAsDirector_Click(object sender, EventArgs e)
        {
            SelectMoviesForm smForm = new SelectMoviesForm();
            if (smForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directorMovies = smForm.SelectedMovies;
                tbMoviesAsDirector.Text = String.Join(",", directorMovies);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fName = tbFirstName.Text;
            string lName = tbLastName.Text;
            DateTime bDay = dtpBirthday.Value;
            List<Movie> aMovies = (actorMovies != null) ? actorMovies.ToList<Movie>() : new List<Movie>();
            List<Movie> dMovies = (directorMovies != null) ? directorMovies.ToList<Movie>() : new List<Movie>();
            Person newP = new Person() 
                            { 
                                FirstName = fName, 
                                LastName = lName, 
                                Birthday = bDay, 
                                MoviesAsActor = aMovies, 
                                MoviesAsDirector = dMovies
                            };
            using (var db = new MovieDbContext())
            {
                db.People.Add(newP);
                db.SaveChanges();
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
