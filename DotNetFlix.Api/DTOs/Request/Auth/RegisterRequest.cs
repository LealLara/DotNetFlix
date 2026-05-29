using DotNetFlix.Api.Model.Auth;

namespace DotNetFlix.Api.DTOs.Request.Auth
{
    public class RegisterRequest
    {
        public string Name { get; set; }

        public string Email { get; set; } 
        public string Document { get; set; }

        public RegisterRequestModel ToModel()
        {
            return new(
                name: Name,
                email: Email,
                password: Password);
        }
    }
}