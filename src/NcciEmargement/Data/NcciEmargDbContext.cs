using Microsoft.EntityFrameworkCore;
using NcciEmargement.Models;

namespace NcciEmargement.Data
{
    public class NcciEmargDbContext : DbContext
    {
        public NcciEmargDbContext(DbContextOptions<NcciEmargDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<Company>().Ignore(t => t.Employees);

            modelBuilder.Entity<Employee>()
                .HasOne(c => c.Company).WithMany(e => e.Employees).HasForeignKey(c => c.CompanyId);
        }
    }
}
