using DotNetFlix.Domain.Entities.UserData.User;

namespace DotNetFlix.Application.Interfaces.IRepository
{
    public interface IUserRepository
    {
        Task<UserEntity?> GetByEmailAsync(string email);

        Task<UserEntity?> GetByIdAsync(Guid id);

        Task CreateAsync(UserEntity user);
    }
}