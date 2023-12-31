using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.ApplicationUser;
using ComputerHardwareECommerceApi.Application.Dtos.ApplicationUserDtos;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class ApplicationUserProfile:Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserDto>().ReverseMap();
            CreateMap<ApplicationUser,ApplicationUserCreateDto>().ReverseMap();
            CreateMap<ApplicationUser,ApplicationUserUpdateDto>().ReverseMap();
        }
    }
}
