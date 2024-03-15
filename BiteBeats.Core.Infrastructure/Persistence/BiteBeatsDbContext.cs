using Microsoft.EntityFrameworkCore;
using BiteBeats.Core.Entities.Entity;

namespace BiteBeats.Core.Infrastructure.Persistence
{
    public class BiteBeatsDbContext : DbContext
    {
        public BiteBeatsDbContext(DbContextOptions<BiteBeatsDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        public DbSet<Restuarant> Restaurant { get; set; }
        public DbSet<User> User { get; set; }
    }
}
