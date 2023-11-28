namespace HelpDeskBackend.Models.DTO
{
    public class TicketCreationDto
    {
        public int TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OpenedById { get; set; }
    }
}
