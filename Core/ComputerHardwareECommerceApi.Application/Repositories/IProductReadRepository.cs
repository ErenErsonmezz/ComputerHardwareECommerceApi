

using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Repositories
{
    public interface IProductReadRepository:IReadRepository<Product>
    {
       Task<IEnumerable<Product>> GetProductsWithCategoryAsync(Pagination pagination, bool tracking = false);
    }
}
