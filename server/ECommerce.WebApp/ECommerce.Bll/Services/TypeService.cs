using AutoMapper;
using ECommerce.Bll.Interfaces;
using ECommerce.Common.Dtos.Types;
using ECommerce.Dal.Interfaces;
using Type = ECommerce.Domain.Type;

namespace ECommerce.Bll.Services
{
    public class TypeService : ITypeService
    {
        private readonly IRepository<Type> _typeRepository;
        private readonly IMapper _mapper;

        public TypeService(IRepository<Type> typeRepository, IMapper mapper)
        {
            _typeRepository = typeRepository;
            _mapper = mapper;
        }

        public async Task CreateTypeAsync(CreateTypeDto dto)
        {
            var type = _mapper.Map<Type>(dto);
            await _typeRepository.AddAsync(type);
        }

        public async Task DeleteTypeAsync(int id)
        {
            var type = await _typeRepository.GetByIdAsync(id);
            await _typeRepository.DeleteAsync(type);
        }

        public async Task<TypeDto> GetTypeByIdAsync(int id)
        {
            var type = await _typeRepository.GetByIdAsync(id);
            var result = _mapper.Map<TypeDto>(type);
            return result;
        }

        public async Task<IEnumerable<TypeDto>> GetTypesAsync()
        {
            var types = await _typeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TypeDto>>(types);
        }
    }
}
