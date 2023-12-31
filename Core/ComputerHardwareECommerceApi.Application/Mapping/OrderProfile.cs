
using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.OrderDtos;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<Order,OrderDto>().ReverseMap();
            CreateMap<Order,OrderCreateDto>().ReverseMap();
            CreateMap<Order,OrderUpdateDto>().ReverseMap();
        }
    }
}
