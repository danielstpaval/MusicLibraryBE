using MusicLibrary.DataAccess.Interfaces;
using MusicLibrary.DataAccess.Models;

namespace MusicLibrary.DataAccess.Repository
{
    public class SongRepository : ISongRepository
    {
        private readonly MusicLibraryContext _context;

        public SongRepository(MusicLibraryContext context)
        {
            _context = context;
        }

        public Task<Song> GetSongByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<Song>> ISongRepository.GetSongsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
