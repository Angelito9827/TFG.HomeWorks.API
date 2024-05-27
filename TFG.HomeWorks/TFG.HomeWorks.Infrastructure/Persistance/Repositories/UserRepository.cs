using Microsoft.EntityFrameworkCore;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Domain.Entities.UserAggregate;

namespace TFG.HomeWorks.Infrastructure.Persistance.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
        }

        public async Task<bool> UserExistByEmail(string email)
        {
            return await _dbContext.Users
                .AnyAsync(x => x.Email.ToLower().Equals(email.ToLower()));
        }

        public async Task<bool> UserExist(string email, string username)
        {
            return await _dbContext.Users
                .AnyAsync(x => x.Email.ToLower().Equals(email.ToLower())
                || x.Username.ToLower().Equals(username.ToLower()));
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await _dbContext.Users
                .FirstOrDefaultAsync(x => x.Email.ToLower().Equals(email.ToLower()));
        }

        public async Task Add(User user)
        {
            await _dbContext.Users.AddAsync(user);
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
