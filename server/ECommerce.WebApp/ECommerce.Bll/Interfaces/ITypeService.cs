using ECommerce.Common.Dtos.Types;

namespace ECommerce.Bll.Interfaces
{
    public interface ITypeService
    {
        Task<IEnumerable<TypeDto>> GetTypesAsync();
        Task<TypeDto> GetTypeByIdAsync(int id);
        Task CreateTypeAsync(CreateTypeDto dto);
        Task DeleteTypeAsync(int id);
    }
}
