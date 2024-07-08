using Microsoft.EntityFrameworkCore;

namespace MusicLibrary.DataAccess.Models
{
    public class MusicLibraryContext : DbContext
    {
        public MusicLibraryContext(DbContextOptions<MusicLibraryContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }
    }
}
