

using ComputerHardwareECommerceApi.Application.Dtos;
using ComputerHardwareECommerceApi.Application.Dtos.Product;
using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Application.ViewModels;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.DataServices
{
    public interface IProductDataService : IDataService<Product, ProductDto>
    {
        Task<CustomResponseDto<IEnumerable<ProductWithCategoryViewModel>>> GetProductsWithCategoryAsync(Pagination pagination);
    }
}
