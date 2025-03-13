using Microsoft.EntityFrameworkCore;

namespace PeerToPeerWebService.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
