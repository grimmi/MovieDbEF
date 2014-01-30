using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MovieDbEF
{
    class Program
    {
        static void Main(string[] args)
        {
            DbgForm dForm = new DbgForm();
            dForm.ShowDialog();
        }
    }
}
