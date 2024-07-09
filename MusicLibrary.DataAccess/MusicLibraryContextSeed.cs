using Microsoft.Extensions.Logging;
using MusicLibrary.DataAccess.Models;
using System.Text.Json;

namespace MusicLibrary.DataAccess
{
    public class MusicLibraryContextSeed
    {
        public static async Task SeedAsync(MusicLibraryContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Artists.Any())
                {
                    var jsonData = File.ReadAllText("../MusicLibrary.DataAccess/SeedData/data.json");

                    var list = JsonSerializer.Deserialize<List<Artist>>(jsonData);

                    foreach (var artist in list)
                    {
                        context.Artists.Add(artist);

                        if (artist.Albums != null)
                        {
                            foreach (var album in artist.Albums)
                            {
                                album.ArtistId = artist.Id;

                                context.Albums.Add(album);

                                if (album.Songs != null)
                                {
                                    foreach (var song in album.Songs)
                                    {
                                        song.AlbumId = album.Id;

                                        context.Songs.Add(song);
                                    }

                                }

                            }
                        }
                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<MusicLibraryContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
