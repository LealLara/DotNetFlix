using DotNetFlix.Application.Interfaces.IRepository;
using DotNetFlix.Application.Interfaces.Repositories;
using DotNetFlix.Domain.Entities.UserData.User;
using DotNetFlix.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotNetFlix.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(
            AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserEntity?> GetByEmailAsync(string email)
        {
            return await _context.Users

                .FirstOrDefaultAsync(
                    x => x.Email == email);
        }

        public async Task<UserEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Users
                .FirstOrDefaultAsync(
                    x => x.Id == id);
        }

        public async Task CreateAsync(UserEntity user)
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }
    }
}