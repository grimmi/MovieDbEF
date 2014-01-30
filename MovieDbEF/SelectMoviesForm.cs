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
    public partial class SelectMoviesForm : Form
    {
        public IEnumerable<Movie> SelectedMovies 
        {
            get
            {
                return clbMovies.CheckedItems.Cast<Movie>();
            } 
        }

        public SelectMoviesForm()
        {
            InitializeComponent();
            using (var db = new MovieDbContext())
            {
                foreach (var m in db.Movies)
                {
                    clbMovies.Items.Add(m);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
