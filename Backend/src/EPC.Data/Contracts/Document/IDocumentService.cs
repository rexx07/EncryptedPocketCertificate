using EPC.Core.Domain.Documents;

namespace EPC.Data.Contracts
{
    public interface IDocumentService : IServiceBase<Document>
    {
        Task<IEnumerable<Document>> GetAllDocumentsAsync();
        Task<Document> GetDocumentByIdAsync(string fileName);
        void CreateDocument(Document document);
        void UpdateDocument(Document document);
        void DeleteDocument(Document document);
    }
}
