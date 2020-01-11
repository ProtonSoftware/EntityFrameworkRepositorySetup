using Microsoft.EntityFrameworkCore;

namespace ProtonSoftwareEntityFrameworkCore.Database
{
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        protected override DbSet<Product> DbSet => Database.Products;

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
