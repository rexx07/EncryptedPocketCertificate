using EPC.Core.Domain.Users;
using EPC.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EPC.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
