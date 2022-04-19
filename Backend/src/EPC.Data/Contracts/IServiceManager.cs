namespace EPC.Data.Contracts
{
    public interface IServiceManager
    {
        IUserService User { get; }
        IDocumentService Document { get; }
        Task SaveAsync();
    }
}
