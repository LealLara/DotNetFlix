using DotNetFlix.Api.Model.Auth;

namespace DotNetFlix.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task RegisterAsync(RegisterRequestModel dto);

        Task<LoginResponseModel> LoginAsync(
            LoginRequestModel dto);
    }
}