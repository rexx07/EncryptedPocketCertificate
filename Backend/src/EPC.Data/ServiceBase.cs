using EPC.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EPC.Data
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public ServiceBase(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public AppDbContext CreateDbContext()
        {
            var context = _contextFactory.CreateDbContext();
            return context;
        }

        public IQueryable<T> FindAll()
        {
            return CreateDbContext().Set<T>().AsNoTracking();
        }


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return CreateDbContext().Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            CreateDbContext().Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            CreateDbContext().Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            CreateDbContext().Set<T>().Remove(entity);
        }
    }
}