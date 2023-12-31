

using ComputerHardwareECommerceApi.Application.Dtos;
using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Domain.Models.Common;
using System.Linq.Expressions;

namespace ComputerHardwareECommerceApi.Application.DataServices
{
    public interface IDataService<Entity,Dto> where Entity : BaseEntity where Dto : BaseDto
    {
        Task<CustomResponseDto<IEnumerable<Dto>>>  GetAllAsync(Pagination pagination);
        Task<CustomResponseDto<Dto>> GetByIdAsync(string id);
        Task<CustomResponseDto<IEnumerable<Dto>>> WhereAsync(Expression<Func<Entity, bool>> expression);
        Task<CustomResponseDto<Dto>> GetSingleValueAsync(Expression<Func<Entity, bool>> expression);
        Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<Entity, bool>> expression);
        Task<CustomResponseDto<Dto>> AddAsync(BaseDto dto);
        Task<CustomResponseDto<NoContentDto>> AddRangeAsync(IEnumerable<BaseDto> dtos);
        Task<CustomResponseDto<bool>> UpdateAsync(BaseDto dto);
        Task<CustomResponseDto<bool>> DeleteAsync(string id);
        Task<CustomResponseDto<bool>> DeleteRangeAsync(IEnumerable<string> ids);
    }
}
