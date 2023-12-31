

using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.ProductImageFile;
using ComputerHardwareECommerceApi.Application.Dtos.ProductImageFileDtos;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class ProductImageFileProfile:Profile
    {
        public ProductImageFileProfile()
        {
            CreateMap<ProductImageFile,ProductImageFileDto>().ReverseMap();
            CreateMap<ProductImageFile, ProductImageFileCreateDto>().ReverseMap();
        }
    }
}
