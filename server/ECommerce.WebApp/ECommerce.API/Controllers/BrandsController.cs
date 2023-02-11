using ECommerce.Bll.Interfaces;
using ECommerce.Common.Dtos.Brands;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/brands")]
    public class BrandsController : AppBaseController
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBrandsAsync()
        {
            var brands = await _brandService.GetBrandsAsync();
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandAsync(int id)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
            return Ok(brand);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrandAsync([FromBody] CreateBrandDto brandDto)
        {
            await _brandService.CreateBrandAsync(brandDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrandAsync(int id)
        {
            await _brandService.DeleteBrandAsync(id);
            return NoContent();
        }
    }
}
