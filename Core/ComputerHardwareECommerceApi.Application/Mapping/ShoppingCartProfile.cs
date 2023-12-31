

using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.ShoppingCartDtos;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class ShoppingCartProfile:Profile
    {
        public ShoppingCartProfile()
        {
            CreateMap<ShoppingCart,ShoppingCartDto>().ReverseMap();
            CreateMap<ShoppingCart,ShoppingCartCreateDto>().ReverseMap();   
            CreateMap<ShoppingCart,ShoppingCartUpdateDto>().ReverseMap();
        }
    }
}
