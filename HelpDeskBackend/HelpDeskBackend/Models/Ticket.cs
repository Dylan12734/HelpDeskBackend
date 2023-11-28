
namespace HelpDeskBackend.Models
{
    public class Ticket: BaseEntity
    {
        public int TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OpenedById { get; set; }
        public int? ResolvedById { get; set; }
    }

}
