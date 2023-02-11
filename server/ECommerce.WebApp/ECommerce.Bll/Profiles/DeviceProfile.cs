using AutoMapper;
using ECommerce.Common.Dtos.Devices;
using ECommerce.Domain;

namespace ECommerce.Bll.Profiles
{
    public class DeviceProfile : Profile
    {
        public DeviceProfile()
        {
            CreateMap<Device, DeviceDto>()
                .ForMember(x => x.Type, y => y.MapFrom(z => z.Type.Name))
                .ForMember(x => x.Brand, y => y.MapFrom(z => z.Brand.Name));

            CreateMap<DeviceInfo, DeviceInfoDto>();
            CreateMap<CreateDeviceDto, Device>();
            CreateMap<CreateDeviceInfoDto, DeviceInfo>();
        }
    }
}
