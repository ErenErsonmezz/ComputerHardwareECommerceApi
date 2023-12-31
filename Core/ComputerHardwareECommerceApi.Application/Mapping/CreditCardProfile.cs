
using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.CreditCardDtos;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class CreditCardProfile:Profile
    {
        public CreditCardProfile()
        {
            CreateMap<CreditCard,CreditCardDto>().ReverseMap();
            CreateMap<CreditCard,CreditCardCreateDto>().ReverseMap();
            CreateMap<CreditCard,CreditCardUpdateDto>().ReverseMap();
        }
    }
}
