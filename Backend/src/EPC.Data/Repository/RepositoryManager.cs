using EPC.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EPC.Data.Repository
{
    public class RepositoryManager : IRepositoryManager, IDbContextFactory<AppDbContext>
    {
        //private readonly AppDbContext _appDbContext;
        private readonly IDbContextFactory<AppDbContext> _dbContext;

        public IDocumentRepository _documentRepository;
        public IUserRepository _userRepository;
        public RepositoryManager(IDbContextFactory<AppDbContext> contextFactory)
        {
            _dbContext = contextFactory;
            //using (var appDbCotextFactory = _dbContextFactory.CreateDbContext());
        }

        public AppDbContext CreateDbContext()
        {
            return _dbContext.CreateDbContext();
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(CreateDbContext());

                return _userRepository;
            }
        }

        public IDocumentRepository Document
        {
            get
            {
                if (_documentRepository == null)
                    _documentRepository = new DocumentRepository(CreateDbContext());

                return _documentRepository;
            }
        }

        public void Save() => CreateDbContext().SaveChanges();

        //public ValueTask DisposeAsync()
        //{
        //    return _appDbContext.DisposeAsync();
        //}
    }
}
