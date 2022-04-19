using EPC.Core.Domain.Users;

namespace EPC.Data.Contracts
{
    public interface IUserService : IServiceBase<User>
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid userGuid);
        Task<User> GetUserWithDetailsAsync(Guid userGuid);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
