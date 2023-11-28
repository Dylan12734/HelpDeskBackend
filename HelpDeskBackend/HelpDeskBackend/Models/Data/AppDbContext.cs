using HelpDeskBackend.Models.DTO;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HelpDeskBackend.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
        

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Favorites> Favorites { get; set; }

    }
}
