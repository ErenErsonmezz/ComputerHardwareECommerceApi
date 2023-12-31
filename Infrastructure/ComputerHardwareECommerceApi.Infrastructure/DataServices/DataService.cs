using AutoMapper;
using ComputerHardwareECommerceApi.Application.DataServices;
using ComputerHardwareECommerceApi.Application.Dtos;
using ComputerHardwareECommerceApi.Application.Repositories;
using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Application.UnitOfWorks;
using ComputerHardwareECommerceApi.Domain.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ComputerHardwareECommerceApi.Infrastructure.DataServices
{
    public class DataService<Entity, Dto> : IDataService<Entity, Dto> where Entity : BaseEntity where Dto : BaseDto
    {
        protected readonly IWriteRepository<Entity> _writeRepository;
        protected readonly IReadRepository<Entity> _readRepository;
        protected IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public DataService(IWriteRepository<Entity> writeRepository, IReadRepository<Entity> readRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomResponseDto<Dto>> AddAsync(BaseDto dto)
        {
            var entity=_mapper.Map<Entity>(dto);
            var valueDto= _mapper.Map<Dto>(await _writeRepository.AddAsync(entity));
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<Dto>.Success(201,valueDto);
        }

        public async Task<CustomResponseDto<NoContentDto>> AddRangeAsync(IEnumerable<BaseDto> dtos)
        {
            var entities = _mapper.Map<IEnumerable<Entity>>(dtos);
            await _writeRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(201);
        }

        public async Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<Entity, bool>> expression)
        {
            if(await _readRepository.AnyAsync(expression,false))
                return CustomResponseDto<bool>.Success(200);
            return CustomResponseDto<bool>.Fail(500,"Beklenmeyen bir hata oluştu");
        }

        public async Task<CustomResponseDto<bool>> DeleteAsync(string id)
        {
            var entity=await _readRepository.GetByIdAsync(id,true);
            if (_writeRepository.Delete(entity))
            {
                await _unitOfWork.CommitAsync();
                return CustomResponseDto<bool>.Success(204);
            }
            return CustomResponseDto<bool>.Fail(500, "Beklenmeyen bir hata oluştu");
        }

        public async Task<CustomResponseDto<bool>> DeleteRangeAsync(IEnumerable<string> ids)
        {
            List<Entity> entities =new();
            foreach(var item in ids)
            {
                entities.Add(await _readRepository.GetByIdAsync(item,true));
            }
            if (_writeRepository.DeleteRange(entities))
            {
                await _unitOfWork.CommitAsync();
                return CustomResponseDto<bool>.Success(200);
            }
            return CustomResponseDto<bool>.Fail(500, "Beklenmeyen bir hata oluştu");
        }

        public async Task<CustomResponseDto<IEnumerable<Dto>>> GetAllAsync(Pagination pagination)
        {
            var entities =await _readRepository.GetAll(pagination,false).ToListAsync();
            var dtos = _mapper.Map<IEnumerable<Dto>>(entities);
            return CustomResponseDto<IEnumerable<Dto>>.Success(200, dtos);
        }

        public async Task<CustomResponseDto<Dto>> GetByIdAsync(string id)
        {
            var entity=await _readRepository.GetByIdAsync(id);
            var dto=_mapper.Map<Dto>(entity);
            return CustomResponseDto<Dto>.Success(200, dto);

        }

        public async Task<CustomResponseDto<Dto>> GetSingleValueAsync(Expression<Func<Entity, bool>> expression)
        {
            var entity=await _readRepository.GetSingleValueAsync(expression, false);
            var dto=_mapper.Map<Dto>(entity);
            return CustomResponseDto<Dto>.Success(200, dto);
        }

        public async Task<CustomResponseDto<bool>> UpdateAsync(BaseDto dto)
        {
            var entity=_mapper.Map<Entity>(dto);
            if (_writeRepository.Update(entity))
            {
                await _unitOfWork.CommitAsync();
                return CustomResponseDto<bool>.Success(204);
            }
            return CustomResponseDto<bool>.Fail(500, "Beklenmeyen bir hata oluştu");
        }

        public async Task<CustomResponseDto<IEnumerable<Dto>>> WhereAsync(Expression<Func<Entity, bool>> expression)
        {
            var entities=await _readRepository.Where(expression,false).ToListAsync();
            var dtos=_mapper.Map<IEnumerable<Dto>>(entities);
            return CustomResponseDto<IEnumerable<Dto>>.Success(200, dtos);
        }
    }
}
