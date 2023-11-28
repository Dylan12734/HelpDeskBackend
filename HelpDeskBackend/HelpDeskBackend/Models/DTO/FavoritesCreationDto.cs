namespace HelpDeskBackend.Models.DTO
{
    public class FavoritesCreationDto
    {
        public int FavoritesId { get; set; }
        public int UserId { get; set; }
        public int TicketId { get; set; }
    }
}
