using AutoMapper;
using ECommerce.Common.Dtos.Users;
using ECommerce.Domain.Auth;

namespace ECommerce.Bll.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, RegisterUserDto>();
            CreateMap<RegisterUserDto, User>();
            CreateMap<LoginUserDto, User>();
            CreateMap<User, LoginUserDto>();
        }
    }
}
