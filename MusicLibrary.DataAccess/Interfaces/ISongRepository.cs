using MusicLibrary.DataAccess.Models;

namespace MusicLibrary.DataAccess.Interfaces
{
    public interface ISongRepository
    {
        Task<Song> GetSongByIdAsync(int id);

        Task<IReadOnlyList<Song>> GetSongsAsync();
    }
}
