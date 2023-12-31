

using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.BaseFileDtos;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class BaseFileProfile:Profile
    {
        public BaseFileProfile()
        {
            CreateMap<BaseFile, BaseFileDto>().ReverseMap();
            CreateMap<BaseFile, BaseFileCreateDto>().ReverseMap();
        }
    }
}
