using Microsoft.EntityFrameworkCore;

namespace ProtonSoftwareEntityFrameworkCore.Database
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        protected override DbSet<User> DbSet => Database.Users;

        public UserRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
