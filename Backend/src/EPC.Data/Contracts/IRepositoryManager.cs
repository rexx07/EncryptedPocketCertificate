namespace EPC.Data.Contracts
{
    public interface IRepositoryManager
    {
        IDocumentRepository Document { get; }
        IUserRepository User { get; }
        void Save();
    }
}
