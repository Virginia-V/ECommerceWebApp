using ECommerce.Bll.Interfaces;
using ECommerce.Common.Dtos.Types;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/types")]
    public class TypesController : AppBaseController
    {
        private readonly ITypeService _typeService;

        public TypesController(ITypeService typeService)
        {
            _typeService = typeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTypesAsync()
        {
            var types = await _typeService.GetTypesAsync();
            return Ok(types);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTypeAsync(int id)
        {
            var type = await _typeService.GetTypeByIdAsync(id);
            return Ok(type);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTypeAsync([FromBody] CreateTypeDto typeDto)
        {
            await _typeService.CreateTypeAsync(typeDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeAsync(int id)
        {
            await _typeService.DeleteTypeAsync(id);
            return NoContent();
        }
    }
}
