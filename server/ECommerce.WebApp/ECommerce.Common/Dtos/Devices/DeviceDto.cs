namespace ECommerce.Common.Dtos.Devices
{
    public class DeviceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public IEnumerable<DeviceInfoDto> DeviceInfos { get; set; }
    }
}
