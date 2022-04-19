using EPC.Core.Domain.Users;
using EPC.Services;

namespace EPC.WebApi.GraphQLServer.Queries
{
    [ExtendObjectType("Query")]
    public class UserQueries
    {
        public async Task<IEnumerable<User>> GetUsers(ServiceManager serviceManager)
        {
            return await serviceManager.User.GetAllUsersAsync();
        }
    }
}
