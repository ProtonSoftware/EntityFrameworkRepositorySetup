using Microsoft.EntityFrameworkCore;

namespace ProtonSoftwareEntityFrameworkCore.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
