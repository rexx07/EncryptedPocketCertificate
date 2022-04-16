using EPC.Core.Domain.Documents;
using EPC.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EPC.Data.Repository
{
    public class DocumentRepository : RepositoryBase<Document>, IDocumentRepository
    {
        public DocumentRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
