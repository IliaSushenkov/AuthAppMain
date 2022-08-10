using System.Data.Entity;

namespace WpfApp1
{
    public class AppContextForClient : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public AppContextForClient() : base("DefaultConnection") { }
    }
}
