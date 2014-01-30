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
    public partial class SelectPeopleForm : Form
    {
        public IEnumerable<Person> SelectedPeople
        {
            get
            {
                return checkedListBox1.CheckedItems.Cast<Person>();
            }
        }
        public SelectPeopleForm()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            checkedListBox1.Items.Clear();
            using (var db = new MovieDbContext())
            {
                foreach (var p in db.People)
                {
                    checkedListBox1.Items.Add(p);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPersonForm apForm = new AddPersonForm();
            if (apForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateListBox();
            }
        }
    }
}
