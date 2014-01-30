using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbEF
{
    public class Person
    {
        static MovieDbContext ctx = new MovieDbContext();
        [Key]
        public int PersonId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public virtual ICollection<Movie> MoviesAsActor { get; set; }
        public virtual ICollection<Movie> MoviesAsDirector { get; set; }
        public Person()
        {
            MoviesAsActor = new List<Movie>();
            MoviesAsDirector = new List<Movie>();
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
            
        }
    }
}
