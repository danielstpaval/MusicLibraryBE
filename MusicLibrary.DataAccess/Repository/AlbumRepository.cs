using Microsoft.EntityFrameworkCore;
using MusicLibrary.DataAccess.Interfaces;
using MusicLibrary.DataAccess.Models;

namespace MusicLibrary.DataAccess.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly MusicLibraryContext _context;

        public AlbumRepository(MusicLibraryContext context)
        {
            _context = context;
        }

        public async Task<Album> GetAlbumByIdAsync(int id)
        {
            return await _context.Albums.FindAsync(id);
        }

        public async Task<IReadOnlyList<Album>> GetAlbumsAsync()
        {
            return await _context.Albums.ToListAsync();
        }
    }
}
