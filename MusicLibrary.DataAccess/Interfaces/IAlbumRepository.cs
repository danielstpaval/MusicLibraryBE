using MusicLibrary.DataAccess.Models;

namespace MusicLibrary.DataAccess.Interfaces
{
    public interface IAlbumRepository
    {
        Task<Album> GetAlbumByIdAsync(int id);

        Task<IReadOnlyList<Album>> GetAlbumsAsync();
    }
}
