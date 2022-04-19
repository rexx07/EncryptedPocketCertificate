using EPC.Core.Domain.Documents;
using EPC.Services;

namespace EPC.WebApi.GraphQLServer.Queries
{
    [ExtendObjectType("Query")]
    public class DocumentQueries
    {
        public async Task<IEnumerable<Document>> GetDocuments(ServiceManager serviceManager)
        {
            return await serviceManager.Document.GetAllDocumentsAsync();
        }
    }
}
