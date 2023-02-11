using AutoMapper;
using ECommerce.Bll.Interfaces;
using ECommerce.Common.Dtos.Brands;
using ECommerce.Dal.Interfaces;
using ECommerce.Domain;

namespace ECommerce.Bll.Services
{
    public class BrandService : IBrandService
    {
        private readonly IRepository<Brand> _brandRepository;
        private readonly IMapper _mapper;

        public BrandService(IRepository<Brand> brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task CreateBrandAsync(CreateBrandDto dto)
        {
            var brand = _mapper.Map<Brand>(dto);
            await _brandRepository.AddAsync(brand);
        }

        public async Task DeleteBrandAsync(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            await _brandRepository.DeleteAsync(brand);
        }

        public async Task<BrandDto> GetBrandByIdAsync(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            var result = _mapper.Map<BrandDto>(brand);
            return result;
        }

        public async Task<IEnumerable<BrandDto>> GetBrandsAsync()
        {
            var brands = await _brandRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BrandDto>>(brands);
        }
    }
}
