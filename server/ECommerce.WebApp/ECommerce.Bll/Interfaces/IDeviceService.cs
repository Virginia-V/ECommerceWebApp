using ECommerce.Common.Dtos.Devices;

namespace ECommerce.Bll.Interfaces
{
    public interface IDeviceService
    {
        Task<IEnumerable<DeviceDto>> GetDevicesAsync();
        Task<DeviceDto> GetDeviceByIdAsync(int id);
        Task CreateDeviceAsync(CreateDeviceDto dto);
        Task DeleteDeviceAsync(int id);
    }
}
