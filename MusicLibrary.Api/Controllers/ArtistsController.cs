using Microsoft.AspNetCore.Mvc;
using MusicLibrary.DataAccess.Interfaces;
using MusicLibrary.DataAccess.Models;

namespace MusicLibraryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistRepository _repository;

        public ArtistsController(IArtistRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Artist>>> GetArtists()
        {
            try
            {
                var products = await _repository.GetArtistsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtist(int id)
        {
            try
            {
                var artist = await _repository.GetArtistByIdAsync(id);
                return Ok(artist);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
