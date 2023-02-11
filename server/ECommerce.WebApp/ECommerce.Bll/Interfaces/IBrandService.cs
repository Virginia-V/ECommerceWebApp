using ECommerce.Common.Dtos.Brands;

namespace ECommerce.Bll.Interfaces
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandDto>> GetBrandsAsync();
        Task<BrandDto> GetBrandByIdAsync(int id);
        Task CreateBrandAsync(CreateBrandDto dto);
        Task DeleteBrandAsync(int id);
    }
}
