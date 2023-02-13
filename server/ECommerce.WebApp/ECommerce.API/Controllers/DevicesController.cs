using ECommerce.Bll.Interfaces;
using ECommerce.Common.Dtos.Devices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/devices")]
    public class DevicesController : AppBaseController
    {
        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDevicesAsync()
        {
            var devices = await _deviceService.GetDevicesAsync();
            return Ok(devices);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeviceAsync(int id)
        {
            var device = await _deviceService.GetDeviceByIdAsync(id);
            return Ok(device);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeviceAsync([FromBody] CreateDeviceDto deviceDto)
        {
            await _deviceService.CreateDeviceAsync(deviceDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeviceAsync(int id)
        {
            await _deviceService.DeleteDeviceAsync(id);
            return NoContent();
        }
    }
}
