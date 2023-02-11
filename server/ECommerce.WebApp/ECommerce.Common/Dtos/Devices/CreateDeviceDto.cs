namespace ECommerce.Common.Dtos.Devices
{
    public class CreateDeviceDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public IEnumerable<CreateDeviceInfoDto> DeviceInfos { get; set; }
    }
}
