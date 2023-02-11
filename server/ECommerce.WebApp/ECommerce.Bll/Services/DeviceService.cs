using AutoMapper;
using ECommerce.Bll.Interfaces;
using ECommerce.Common.Dtos.Devices;
using ECommerce.Dal.Interfaces;
using ECommerce.Domain;

namespace ECommerce.Bll.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IRepository<Device> _deviceRepository;
        private readonly IMapper _mapper;

        public DeviceService(IRepository<Device> deviceRepository, IMapper mapper)
        {
            _deviceRepository = deviceRepository;
            _mapper = mapper;
        }

        public async Task CreateDeviceAsync(CreateDeviceDto dto)
        {
            var device = _mapper.Map<Device>(dto);
            await _deviceRepository.AddAsync(device);
        }

        public async Task DeleteDeviceAsync(int id)
        {
            var device = await _deviceRepository.GetByIdAsync(id);
            await _deviceRepository.DeleteAsync(device);
        }

        public async Task<DeviceDto> GetDeviceByIdAsync(int id)
        {
            var device = await _deviceRepository.GetByIdAsync(id);
            var result = _mapper.Map<DeviceDto>(device);
            return result;
        }

        public async Task<IEnumerable<DeviceDto>> GetDevicesAsync()
        {
            var devices = await _deviceRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DeviceDto>>(devices);
        }
    }
}
