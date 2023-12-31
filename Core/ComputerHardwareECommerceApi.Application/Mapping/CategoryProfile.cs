

using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.Category;
using ComputerHardwareECommerceApi.Application.ViewModels;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category,CategoryCreateDto>().ReverseMap();
            CreateMap<Category,CategoryUpdateDto>().ReverseMap();
            CreateMap<Category, ProductWithCategoryViewModel>().ReverseMap();
        }
    }
}
