

using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.Address;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class AddressProfile:Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Address, AddressCreateDto>().ReverseMap();
            CreateMap<Address,AddressUpdateDto>().ReverseMap();
        }
    }
}
