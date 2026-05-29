using DotNetFlix.Domain.Entities.UserData.User;

namespace DotNetFlix.Application.Interfaces.Services
{
    public interface IJwtProvider
    {
        string Generate(
            UserEntity user);
    }
}