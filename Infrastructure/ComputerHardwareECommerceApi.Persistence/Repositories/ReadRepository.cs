using ComputerHardwareECommerceApi.Application.Repositories;
using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Domain.Models.Common;
using ComputerHardwareECommerceApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ComputerHardwareECommerceApi.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        public DbSet<T> DataTable { get; }
        public ReadRepository(ApplicationDbContext context)
        {
            _context = context;
            DataTable = _context.Set<T>();
        }
 

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression, bool tracking = true)
        {
           var queryable=DataTable.AsQueryable();
           if (!tracking)
                return await queryable.AsNoTracking().AnyAsync(expression);
            
           return await queryable.AnyAsync(expression);
        }

        public IQueryable<T> GetAll(Pagination pagination,bool tracking = true)
        {
            var queryable = DataTable.AsQueryable().Skip(pagination.Page*pagination.PageSize).Take(pagination.PageSize);
            if (!tracking)
                return queryable.AsNoTracking();

            return queryable;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var queryable = DataTable.AsQueryable();
            if (!tracking)
                return await queryable.AsNoTracking().FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            return await queryable.FirstOrDefaultAsync(x => x.Id ==Guid.Parse(id));
        }

        public async Task<T> GetSingleValueAsync(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var queryable = DataTable.AsQueryable();
            if (!tracking)
                return await queryable.AsNoTracking().Where(expression).FirstOrDefaultAsync();
            return await queryable.Where(expression).FirstOrDefaultAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var queryable = DataTable.AsQueryable();
            if (!tracking)
                return queryable.AsNoTracking().Where(expression);
            return queryable.Where(expression);
        }
    }
}
