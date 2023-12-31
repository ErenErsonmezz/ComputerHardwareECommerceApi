

using ComputerHardwareECommerceApi.Application.Repositories;
using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Domain.Models;
using ComputerHardwareECommerceApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ComputerHardwareECommerceApi.Persistence.Repositories.ProductRepositories
{
    public class ProductReadRepository : ReadRepository<Product>,IProductReadRepository
    {
        public ProductReadRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetProductsWithCategoryAsync(Pagination pagination, bool tracking = false)
        {
            var queryable = DataTable.AsQueryable().Skip(pagination.Page * pagination.PageSize).Take(pagination.PageSize);
            if (!tracking)
                return await queryable.AsNoTracking().Include(x=>x.Category).ToListAsync();

            return await queryable.Include(x => x.CategoryId).ToListAsync();
        }
        
    }
}
