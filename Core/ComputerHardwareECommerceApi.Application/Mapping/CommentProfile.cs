
using AutoMapper;
using ComputerHardwareECommerceApi.Application.Dtos.Comment;
using ComputerHardwareECommerceApi.Application.Dtos.CommentDtos;
using ComputerHardwareECommerceApi.Domain.Models;

namespace ComputerHardwareECommerceApi.Application.Mapping
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment,CommentDto>().ReverseMap();
            CreateMap<Comment,CommentCreateDto>().ReverseMap();
            CreateMap<CommentDto,CommentUpdateDto>().ReverseMap();
        }
    }
}
