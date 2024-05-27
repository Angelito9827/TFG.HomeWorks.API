using TFG.HomeWorks.Domain.Entities.UserAggregate;

namespace TFG.HomeWorks.Application.Repositories
{
    public interface IUserRepository
    {
        public Task<bool> UserExistByEmail(string email);
        public Task CreateUserAsync(User user);
        Task<User?> GetUserByEmail(string email);
        Task<bool> UserExist(string email, string username);
        public Task Add(User user);
        public Task SaveChanges();

    }
}
