using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbEF
{
    public class Movie
    {
        public int MovieId { get; set; }
        public String Title { get; set; }
        public int? ReleaseYear { get; set; }
        public int Duration { get; set; }
        public virtual ICollection<Person> Actors { get; set; }
        public virtual ICollection<Person> Directors { get; set; }

        public Movie()
        {
            Actors = new List<Person>();
            Directors = new List<Person>();
        }

        public override string ToString()
        {
            string retString = Title;
            retString += (ReleaseYear != null) ? " (" + ReleaseYear + ")" : "";
            return retString;
        }
    }
}
