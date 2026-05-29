using DotNetFlix.Domain.Models;

namespace DotNetFlix.Application.Interfaces.Services.Pattern
{
    public interface IPatternAccessService
    {S
        public Task<ResultDataModel> CreatePatternRegister();
    }
}