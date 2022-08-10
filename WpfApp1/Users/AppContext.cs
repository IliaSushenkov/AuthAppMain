using System.Data.Entity;

namespace WpfApp1
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
