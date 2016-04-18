
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Internal;
using System.Linq;

namespace MovieAngularJSApp.Models
{
    public class MoviesAppContext : DbContext
    {

        //private readonly string _connectionString;

        private static bool _created = false;

        public MoviesAppContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }


        public DbSet<Movie> Movies { get; set; }

        //public MoviesAppContext(DbContextOptions options)
        //{
        //    _connectionString = ((SqlServerOptionsExtension)options.Extensions.First()).ConnectionString;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_connectionString);
        //}

    }
}
