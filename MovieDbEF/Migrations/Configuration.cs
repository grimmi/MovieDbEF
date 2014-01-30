namespace MovieDbEF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieDbEF.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "movieDb2";
        }

        protected override void Seed(MovieDbEF.MovieDbContext context)
        {
            //Database.SetInitializer<MovieDbContext>(new DropCreateDatabaseIfModelChanges<MovieDbContext>());
            using (var db = new MovieDbContext())
            {
                db.People.RemoveRange(db.People);
                db.Movies.RemoveRange(db.Movies);
                db.SaveChanges();

                Person gc = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "George", LastName = "Clooney" };
                Person rs = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Ridley", LastName = "Scott" };
                Person hf = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Harrison", LastName = "Ford" };
                Person tj = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Tommy Lee", LastName = "Jones" };
                Person jb = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Javier", LastName = "Bardem" };
                Person ec = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Ethan", LastName = "Coen" };
                Person jc = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Joel", LastName = "Coen" };
                Person pj = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Peter", LastName = "Jackson" };
                Person md = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Matt", LastName = "Damon" };
                Person ce = new Person() { Birthday = DateTime.Parse("1980-01-01"), FirstName = "Clint", LastName = "Eastwood" };

                db.People.AddOrUpdate(
                    p => p.FirstName,
                    gc, rs, hf, tj, jb, ec, jc, pj, md, ce
                );
                db.SaveChanges();

                Movie alien = new Movie() { Title = "Alien", ReleaseYear = 1978, Duration = 120 };
                alien.Actors = db.People.Where(p => p.FirstName.Equals("Ridley")).ToList<Person>();

                Movie indiana = new Movie() { Title = "Indiana Jones", ReleaseYear = 1983, Duration = 120 };
                indiana.Actors = db.People.Where(p => p.FirstName.Contains("o")).ToList<Person>();
                indiana.Directors = db.People.Where(p => p.FirstName.StartsWith("George")).ToList<Person>();

                Movie country = new Movie() { Title = "No Country For Old Men", ReleaseYear = 2010, Duration = 120 };
                country.Actors = db.People.Where(p => p.FirstName.Equals("Javier") || p.FirstName.Equals("Tommy Lee")).ToList<Person>();
                country.Directors = db.People.Where(p => p.LastName.Contains("Coen")).ToList<Person>();

                db.Movies.AddOrUpdate(
                    m => m.Title,
                    alien, indiana, country
                );
                db.SaveChanges();
            }
        }
    }
}
