namespace EPC.Data.Contracts
{
    public interface IRepositoryManager
    {
        IDocumentService Document { get; }
        IUserService User { get; }
        Task Save();
    }
}
