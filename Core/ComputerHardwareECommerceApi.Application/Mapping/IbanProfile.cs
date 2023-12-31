

using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.IbanDtos;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class IbanProfile:Profile
    {
        public IbanProfile()
        {
            CreateMap<Iban,IbanDto>().ReverseMap();
            CreateMap<Iban,IbanCreateDto>().ReverseMap();
            CreateMap<Iban,IbanUpdateDto>().ReverseMap();   
        }
    }
}
