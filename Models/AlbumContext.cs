using Microsoft.EntityFrameworkCore;

namespace AlbumApp.Models
{
    public class AlbumContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> Players { get; set; }

        public AlbumContext(DbContextOptions<AlbumContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(c => c.Players)
                .WithOne()
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
