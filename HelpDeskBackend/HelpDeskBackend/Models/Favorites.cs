namespace HelpDeskBackend.Models
{
    public class Favorites : BaseEntity
    {
        public int FavoritesId { get; set; }
        public int UserId { get; set; }
        public int TicketId { get; set; }

    }
}
