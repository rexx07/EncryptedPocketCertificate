using EPC.Core.Domain.Users;
using EPC.Data;

namespace EPC.WebApi.GraphQLServer.Queries
{
    [ExtendObjectType("Query")]
    public class UserQueries
    {
        public IQueryable<User> GetUser([ScopedService] AppDbContext context)
        {
            return context.Users;
        }
    }
}
