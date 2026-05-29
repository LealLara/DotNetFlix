using BCrypt.Net; 
using DotNetFlix.Api.Model.Auth;
using DotNetFlix.Application.Interfaces.IRepository;
using DotNetFlix.Application.Interfaces.Repositories;
using DotNetFlix.Application.Interfaces.Services;
using DotNetFlix.Domain.Entities;

namespace DotNetFlix.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        private readonly IJwtProvider _jwtProvider;

        public AuthService(
            IUserRepository userRepository,
            IJwtProvider jwtProvider)
        {
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task RegisterAsync(
            RegisterRequestModel dto)
        {
            var existingUser =
                await _userRepository
                    .GetByEmailAsync(dto.Email);

            if (existingUser != null)
                throw new Exception(
                    "User already exists");

            string passwordHash =
                BCrypt.Net.BCrypt.HashPassword(
                    dto.Password);

            var user = new UserEntity(
                dto.Name,
                dto.Email,
                passwordHash);

            await _userRepository.CreateAsync(user);
        }

        public async Task<LoginResponseModel> LoginAsync(
            LoginRequestModel dto)
        {
            var user =
                await _userRepository
                    .GetByEmailAsync(dto.Email);

            if (user == null)
                throw new Exception(
                    "Invalid credentials");

            bool isValid =
                BCrypt.Net.BCrypt.Verify(
                    dto.Password,
                    user.PasswordHash);

            if (!isValid)
                throw new Exception(
                    "Invalid credentials");

            string token =
                _jwtProvider.Generate(user);

            return new LoginResponseModel
            {
                Token = token,
                Name = user.Name,
                Email = user.Email
            };
        }
    }
}