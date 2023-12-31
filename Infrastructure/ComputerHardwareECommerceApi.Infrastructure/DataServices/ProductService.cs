

using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.Product;
using ComputerHardwareECommerceApi.Application.Repositories;
using ComputerHardwareECommerceApi.Application.UnitOfWorks;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Infrastructure.DataServices
{
    public class ProductService : DataService<Product, ProductDto>
    {
        public ProductService(IWriteRepository<Product> writeRepository, IReadRepository<Product> readRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(writeRepository, readRepository, mapper, unitOfWork)
        {
        }
    }
}
