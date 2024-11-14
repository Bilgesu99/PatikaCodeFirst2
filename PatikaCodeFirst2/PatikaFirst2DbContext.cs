using Microsoft.EntityFrameworkCore;

using PatikaCodeFirst2.Models;

namespace PatikaCodeFirst2
{
    public class PatikaFirst2DbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OTTG4TB;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
        }
    }
}
