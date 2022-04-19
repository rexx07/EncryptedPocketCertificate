using EPC.Data;
using EPC.Data.Contracts;
using EPC.Services.DocumentServices;
using EPC.Services.UserServices;
using Microsoft.EntityFrameworkCore;

namespace EPC.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IDbContextFactory<AppDbContext> _context;
        private IDocumentService _documentService;
        private IUserService _userService;

        public ServiceManager(IDbContextFactory<AppDbContext> context)
        {
            _context = context;
        }

        public AppDbContext CreateDbContext()
        {
            var context = _context.CreateDbContext();
            return context;
        }

        public IDocumentService Document
        {
            get
            {
                if (_documentService == null)
                    _documentService = new DocumentService(_context);
                return _documentService;
            }
        }

        public IUserService User
        {
            get
            {
                if (_userService == null)
                    _userService = new UserService(_context);
                return _userService;
            }
        }

        public async Task SaveAsync()
        {
            await CreateDbContext().SaveChangesAsync();
        }
    }
}