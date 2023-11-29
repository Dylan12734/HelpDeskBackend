using HelpDeskBackend.Models;
using HelpDeskBackend.Models.Data;

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
        public Favorites GetFavoritesByFavoritesId(int id, AppDbContext _context)
        {
            Favorites favorites = _context.Favorites.Where(x => x.Id == id).FirstOrDefault();
            return favorites;
        }
        public void UpdateFavorite(Favorites favorite)
        {
            favorite.UpdatedDate = DateTime.UtcNow;

            _context.Favorites.Update(favorite);
            _context.SaveChanges();
        }
        public void DeleteFavorite(int id)
        {
            var favorite = _context.Favorites.Where(f => f.Id == id).FirstOrDefault();
            if (favorite != null)
            {
                favorite.isActive = false;
                favorite.UpdatedDate = DateTime.UtcNow;

                _context.Favorites.Update(favorite);
                _context.SaveChanges();
            }
        }
    }
}
