using AutoMapper;
using ECommerce.Common.Dtos.Types;
using Type = ECommerce.Domain.Type;

namespace ECommerce.Bll.Profiles
{
    public class TypeProfile : Profile
    {
        public TypeProfile()
        {
            CreateMap<Type, TypeDto>();
            CreateMap<CreateTypeDto, Type>();
        }
    }
}
