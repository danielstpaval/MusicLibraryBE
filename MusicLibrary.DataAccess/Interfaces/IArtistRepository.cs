using MusicLibrary.DataAccess.Models;

namespace MusicLibrary.DataAccess.Interfaces
{
    public interface IArtistRepository
    {
        Task<Artist> GetArtistByIdAsync(int id);

        Task<IReadOnlyList<Artist>> GetArtistsAsync();
    }
}
