using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class DatabaseCTX:DbContext
    {
        public DatabaseCTX(DbContextOptions<DatabaseCTX> options):base(options)
        {
        }
        public DbSet<Person> People { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PeopleConfig).Assembly);
            modelBuilder.Entity<Person>().HasQueryFilter(p => p.IsDeleted == false);
        }
    }
}
