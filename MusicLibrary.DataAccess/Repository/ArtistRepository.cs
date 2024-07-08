using Microsoft.EntityFrameworkCore;
using MusicLibrary.DataAccess.Interfaces;
using MusicLibrary.DataAccess.Models;

namespace MusicLibrary.DataAccess.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly MusicLibraryContext _context;

        public ArtistRepository(MusicLibraryContext context)
        {
            _context = context;
        }

        public async Task<Artist> GetArtistByIdAsync(int id)
        {
            return await _context.Artists.FindAsync(id);
        }

        public async Task<IReadOnlyList<Artist>> GetArtistsAsync()
        {
            return await _context.Artists.ToListAsync();
        }
    }
}
