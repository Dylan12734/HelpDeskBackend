namespace HelpDeskBackend.Models.DTO
{
    public class TicketUpdateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ResolvedBy { get; set; }
    }
}
