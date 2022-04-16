using EmargementServer.Models;
using Microsoft.EntityFrameworkCore;

namespace EmargementServer.Data
{
    public class EmServerDbContext : DbContext
    {
        public EmServerDbContext(DbContextOptions<EmServerDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
    }
}
