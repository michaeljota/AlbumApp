using Microsoft.EntityFrameworkCore;

namespace AlbumApp.Models
{
    public class AlbumContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public AlbumContext(DbContextOptions<AlbumContext> options) : base(options) {}
    }
}
