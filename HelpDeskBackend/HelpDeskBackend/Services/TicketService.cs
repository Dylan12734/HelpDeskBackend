using HelpDeskBackend.Models;
using HelpDeskBackend.Models.Data;

namespace HelpDeskBackend.Services
{
    public class TicketService
    {
        private readonly AppDbContext _context;

        public TicketService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Ticket> GetAllTickets()
        {
            return _context.Tickets.Where(t => t.isActive).ToList();
        }
        public Ticket GetTicketById(int id)
        {
            return _context.Tickets.FirstOrDefault(t => t.Id == id && t.isActive);
        }
        public void AddTicket(Ticket ticket)
        {
            ticket.CreatedDate = DateTime.UtcNow;
            ticket.isActive = true;

            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }
        public void UpdateTicket(Ticket ticket)
        {
            ticket.UpdatedDate = DateTime.UtcNow;

            _context.Tickets.Update(ticket);
            _context.SaveChanges();
        }
        public void DeleteTicket(int id)
        {
            var ticket = _context.Tickets.FirstOrDefault(t => t.Id == id);
            if (ticket != null)
            {
                ticket.isActive = false;
                ticket.UpdatedDate = DateTime.UtcNow;

                _context.Tickets.Update(ticket);
                _context.SaveChanges();
            }
        }
    }
}
