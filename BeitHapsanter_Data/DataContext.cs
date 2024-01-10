using Microsoft.EntityFrameworkCore;
using BeitHapsanter_Core.Entitits;

namespace BeitHapsanter_Data
{
    public class DataContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MusicalInstrument> MusicalInstruments { get; set; }
        public DbSet<Provider> Providers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=rruth");
        }

    }
}
