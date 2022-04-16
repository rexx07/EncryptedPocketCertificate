using EPC.Core.Domain.Documents;
using EPC.Core.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace EPC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}