using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MovieDbEF
{
    public partial class DbgForm : Form
    {
        private IEnumerable<Person> movieDirectors;
        private IEnumerable<Person> movieActors;
        private String Info
        {
            get
            {
                return txtBoxInfo.Text;
            }
            set
            {
                txtBoxInfo.Text = value;
            }
        }

        public DbgForm()
        {
            InitializeComponent();
            UpdateLists();
        }

        private void UpdateLists()
        {
            UpdatePeopleList();
            UpdateMoviesList();
        }

        private void UpdatePeopleList()
        {
            using (var db = new MovieDbContext())
            {
                tViewPersons.Nodes.Clear();
                foreach (var p in db.People.Include(p => p.MoviesAsActor).Include(p => p.MoviesAsDirector))
                {
                    TreeNode pNode = new TreeNode();
                    pNode.Text = p.ToString();
                    pNode.Tag = p;
                    foreach (var am in p.MoviesAsActor)
                    {
                        TreeNode amNode = new TreeNode();
                        amNode.Text = "(a) " + am.ToString();
                        amNode.Tag = am;
                        pNode.Nodes.Add(amNode);
                    }
                    foreach (var dm in p.MoviesAsDirector)
                    {
                        TreeNode dmNode = new TreeNode();
                        dmNode.Text = "(d) " + dm.ToString();
                        dmNode.Tag = dm;
                        pNode.Nodes.Add(dmNode);
                    }
                    tViewPersons.Nodes.Add(pNode);
                }
            }
        }

        private void UpdateMoviesList()
        {
            using (var db = new MovieDbContext())
            {
                tViewMovies.Nodes.Clear();
                foreach (var m in db.Movies.Include(m => m.Actors).Include(m => m.Directors))
                {
                    TreeNode mNode = new TreeNode();
                    mNode.Text = m.ToString();
                    mNode.Tag = m;
                    foreach (var a in m.Actors)
                    {
                        TreeNode aNode = new TreeNode();
                        aNode.Text = "(a) " + a.ToString();
                        aNode.Tag = a;
                        mNode.Nodes.Add(aNode);
                    }
                    foreach (var d in m.Directors)
                    {
                        TreeNode dNode = new TreeNode();
                        dNode.Text = "(d) " + d.ToString();
                        dNode.Tag = d;
                        mNode.Nodes.Add(dNode);
                    }
                    tViewMovies.Nodes.Add(mNode);
                }
            }
        }

        private void tViewPersons_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is Person)
            {
                ShowPersonInfo((Person)e.Node.Tag);
            }
            else if (e.Node.Tag is Movie)
            {
                ShowMovieInfo((Movie)e.Node.Tag);
            }
        }

        private void ShowPersonInfo(Person p)
        {
            p = new MovieDbContext().People.Find(p.PersonId);
            string infoString = p.ToString() + Environment.NewLine;
            infoString += "Geboren am: ";
            infoString += (p.Birthday != null) ? ((DateTime)p.Birthday).ToShortDateString() : "n / a";
            infoString += Environment.NewLine;
            infoString += "Filme als Schauspieler: " + Environment.NewLine;
            foreach (var m in p.MoviesAsActor)
            {
                infoString += m.ToString() + Environment.NewLine;
            }
            infoString += "Filme als Regisseur: " + Environment.NewLine;
            foreach (var m in p.MoviesAsDirector)
            {
                infoString += m.ToString() + Environment.NewLine;
            }
            Info = infoString;
        }

        private void ShowMovieInfo(Movie m)
        {

        }

        private void btnChoseActors_Click(object sender, EventArgs e)
        {
            SelectPeopleForm spForm = new SelectPeopleForm();
            if (spForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                movieActors = spForm.SelectedPeople;
                tbMovieActors.Text = String.Join(",", movieActors);
            }
        }

        private void btnChoseDirectors_Click(object sender, EventArgs e)
        {
            SelectPeopleForm spForm = new SelectPeopleForm();
            if (spForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                movieDirectors = spForm.SelectedPeople;
                tbMovieDirectors.Text = String.Join(",", movieDirectors);
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string mTitle = tbMovieTitle.Text;
            int mYear = dtpMovieYear.Value.Year;
            int mDuration = (int)nupMovieDuration.Value;
            if (!String.IsNullOrWhiteSpace(mTitle))
            {
                Movie newMovie = new Movie() 
                                        { 
                                            Title = mTitle, 
                                            ReleaseYear = mYear, 
                                            Duration = mDuration, 
                                            Actors = movieActors.ToList<Person>(), 
                                            Directors = movieDirectors.ToList<Person>() 
                                        };
                using (var db = new MovieDbContext())
                {
                    db.Movies.Add(newMovie);
                    db.SaveChanges();
                }
                UpdateLists();
            }
        }
    }
}
