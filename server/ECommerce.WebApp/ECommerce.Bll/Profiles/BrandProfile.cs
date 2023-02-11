using AutoMapper;
using ECommerce.Common.Dtos.Brands;
using ECommerce.Domain;

namespace ECommerce.Bll.Profiles
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandDto>();
            CreateMap<CreateBrandDto, Brand>();
        }
    }
}
