using EPC.Core.Domain.Documents;
using EPC.Data;
using EPC.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EPC.Services.DocumentServices
{
    public class DocumentService : ServiceBase<Document>, IDocumentService, IAsyncDisposable
    {
        public DocumentService(IDbContextFactory<AppDbContext> context) : base(context)
        {

        }

        public async Task<IEnumerable<Document>> GetAllDocumentsAsync()
        {
            return await FindAll().OrderBy(d => d.FileName).ToListAsync();
        }

        public async Task<Document> GetDocumentByIdAsync(string fileName)
        {
            return await FindByCondition(d => d.FileName.Equals(fileName)).FirstOrDefaultAsync();
        }

        public void CreateDocument(Document document)
        {
            CreateDocument(document);
        }

        public void UpdateDocument(Document document)
        {
            UpdateDocument(document);
        }

        public void DeleteDocument(Document document)
        {
            DeleteDocument(document);
        }

        public ValueTask DisposeAsync()
        {
            return CreateDbContext().DisposeAsync();
        }
    }
}
