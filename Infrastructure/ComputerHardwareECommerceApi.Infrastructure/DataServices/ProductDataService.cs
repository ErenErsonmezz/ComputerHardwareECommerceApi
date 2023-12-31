

using AutoMapper;
using ComputerHardwareECommerceApi.Application.DataServices;
using ComputerHardwareECommerceApi.Application.Dtos;
using ComputerHardwareECommerceApi.Application.Dtos.Product;
using ComputerHardwareECommerceApi.Application.Repositories;
using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Application.UnitOfWorks;
using ComputerHardwareECommerceApi.Application.ViewModels;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Infrastructure.DataServices
{
    public class ProductDataService : DataService<Product, ProductDto>,IProductDataService
    {
        private readonly IProductReadRepository _productReadRepository;
        public ProductDataService(IWriteRepository<Product> writeRepository, IReadRepository<Product> readRepository, IMapper mapper, IUnitOfWork unitOfWork,IProductReadRepository productReadRepository) : base(writeRepository, readRepository, mapper, unitOfWork)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<CustomResponseDto<IEnumerable<ProductWithCategoryViewModel>>> GetProductsWithCategoryAsync(Pagination  pagination)
        {
            int dataTotalCount=_productReadRepository.DataTable.Count();
            var products = await _productReadRepository.GetProductsWithCategoryAsync(pagination);
            var viewsModel=_mapper.Map<IEnumerable<ProductWithCategoryViewModel>>(products);
            return CustomResponseDto<IEnumerable<ProductWithCategoryViewModel>>.Success(200, viewsModel,dataTotalCount);
        }
    }

}

