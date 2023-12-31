

using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.Product;
using ComputerHardwareECommerceApi.Application.ViewModels;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Product,ProductCreateDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
            CreateMap<Product, ProductWithCategoryViewModel>().ReverseMap();
        }
    }
}
