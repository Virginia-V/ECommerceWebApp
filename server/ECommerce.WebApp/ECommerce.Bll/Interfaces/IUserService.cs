using ECommerce.Common.Dtos.Users;

namespace ECommerce.Bll.Interfaces
{
    public interface IUserService
    {
        public Task<RegistrationResponseDto> RegisterAsync(RegisterUserDto registerUserDto);
        public Task<LoginResponseDto> LoginAsync(LoginUserDto loginUserDto);
    }
}
