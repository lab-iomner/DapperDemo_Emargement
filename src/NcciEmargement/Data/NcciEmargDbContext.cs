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


    }
}
