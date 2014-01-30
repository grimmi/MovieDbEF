using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MovieDbEF
{
    class MovieDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Movie>()
                .HasMany(m => m.Actors)
                .WithMany(p => p.MoviesAsActor)
                .Map(
                m =>
                {
                    m.MapLeftKey("MovieId");
                    m.MapRightKey("PersonId");
                    m.ToTable("MovieActors");
                });
            modelBuilder
                .Entity<Movie>()
                .HasMany(m => m.Directors)
                .WithMany(p => p.MoviesAsDirector)
                .Map(
                m =>
                {
                    m.MapLeftKey("MovieId");
                    m.MapRightKey("PersonId");
                    m.ToTable("MovieDirectors");
                });
        }
    }
}
