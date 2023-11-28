using HelpDeskBackend.Models;
using Microsoft.AspNetCore.Mvc;
using HelpDeskBackend.Models.DTO;
using HelpDeskBackend.Services;
using AutoMapper;

namespace HelpDeskBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private readonly FavoritesService _favoritesService;
        private readonly IMapper _mapper;

        public FavoritesController(FavoritesService favoritesService)
        {
            _favoritesService = favoritesService;
        }

        [HttpPost]
        public IActionResult AddFavorite(FavoritesCreationDto favoriteDto)
        {
            var favorite = _mapper.Map<Favorites>(favoriteDto);
            _favoritesService.AddFavorite(favorite);
            
            return CreatedAtRoute(nameof(AddFavorite), new { id = favorite.Id }, favorite);
        }

        [HttpGet("{userId}")]
        public IActionResult GetFavoritesByUserId(int userId)
        {
            var favorites = _favoritesService.GetFavoritesByUserId(userId, _favoritesService.Get_context());
            return Ok(favorites);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFavorite(int id)
        {
            var favorite = _favoritesService.GetFavoritesByFavoritesId(id, _favoritesService.Get_context());
            if(favorite == null)
            {
                return NotFound();
            }
            _favoritesService.DeleteFavorite(id);
            return NoContent();
        }
    }
}
