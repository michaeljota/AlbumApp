using Microsoft.EntityFrameworkCore;

namespace AlbumApp.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> options) : base(options) {}
    }
}
