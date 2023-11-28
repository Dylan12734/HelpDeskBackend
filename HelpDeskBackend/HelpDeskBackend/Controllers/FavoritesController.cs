using HelpDeskBackend.Models;
using Microsoft.AspNetCore.Mvc;
using HelpDeskBackend.Models.DTO;
using HelpDeskBackend.Services;

namespace HelpDeskBackend.Controllers
{
    [ApiController]
    [Route("api/favorites")]
    public class FavoritesController : ControllerBase
    {
        private readonly FavoritesService _favoritesService;

        public FavoritesController(FavoritesService favoritesService)
        {
            _favoritesService = favoritesService;
        }

        [HttpPost]
        public IActionResult AddFavorite([FromBody] Favorites favorite)
        {
            _favoritesService.AddFavorite(favorite);
            return CreatedAtAction("GetFavoritesByUserId", new { userId = favorite.UserId }, favorite);
        }

        [HttpGet("{userId}")]
        public IActionResult GetFavoritesByUserId(int userId)
        {
            var favorites = _favoritesService.GetFavoritesByUserId(userId, _favoritesService.Get_context());
            return Ok(favorites);
        }
    }
}
