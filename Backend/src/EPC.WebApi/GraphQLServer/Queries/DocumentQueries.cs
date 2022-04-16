using EPC.Core.Domain.Documents;
using EPC.Data;

namespace EPC.WebApi.GraphQLServer.Queries
{
    [ExtendObjectType("Query")]
    public class DocumentQueries
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Document> GetDocuments([ScopedService] AppDbContext context)
        {
            return context.Documents;
        }
    }
}
