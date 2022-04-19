using EPC.Core.Domain.Users;
using EPC.Data;
using EPC.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EPC.Services.UserServices
{
    public class UserService : ServiceBase<User>, IUserService, IAsyncDisposable
    {
        public UserService(IDbContextFactory<AppDbContext> context) : base(context)
        {

        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await FindAll().OrderBy(u => u.Username).ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid userGuid)
        {
            return await FindByCondition(u => u.UserGuid.Equals(userGuid)).FirstOrDefaultAsync();
        }

        public async Task<User> GetUserWithDetailsAsync(Guid userGuid)
        {
            return await FindByCondition(u => u.UserGuid.Equals(userGuid)).Include(d =>
                d.Documents).FirstOrDefaultAsync();
        }

        public void CreateUser(User user)
        {
            Create(user);
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
