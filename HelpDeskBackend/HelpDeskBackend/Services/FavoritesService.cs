using HelpDeskBackend.Models;
using HelpDeskBackend.Models.Data;
using HelpDeskBackend.Models.DTO;

namespace HelpDeskBackend.Services
{
    public class FavoritesService
    {
        private readonly AppDbContext _context;

        public FavoritesService(AppDbContext context)
        {
            _context = context;
        }

        public void AddFavorite(Favorites favorite)
        {
            favorite.CreatedDate = DateTime.UtcNow;
            favorite.isActive = true;

            _context.Favorites.Add(favorite);
            _context.SaveChanges();
        }

        public AppDbContext Get_context()
        {
            return _context;
        }

        public List<Favorites> GetFavoritesByUserId(int userId, AppDbContext _context)
        {
            List<Favorites> favorites = _context.Favorites.Where(x => x.UserId == userId && x.isActive).ToList();
            return favorites;
        }
        public void UpdateFavorite(Favorites favorite)
        {
            favorite.UpdatedDate = DateTime.UtcNow;

        }
    }
}
