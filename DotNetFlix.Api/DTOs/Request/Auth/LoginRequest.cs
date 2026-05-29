using DotNetFlix.Api.Model.Auth;

namespace DotNetFlix.Api.DTOs.Request.Auth
{
    public class LoginRequest
    {
        public string NickOrEmail { get; set; }

        public string Password { get; set; }

        public LoginRequestModel ToModel()
        {
            return new (
                nickOrEmail : NickOrEmail,
                password : Password
            );
        }
    }
}