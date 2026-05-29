using DotNetFlix.Domain.Entities.LogData;
using DotNetFlix.Domain.Models.Structure;

namespace DotNetFlix.Application.Interfaces.IRepository
{
    public interface ILogCriticityRepository
    {
        Task<List<LogCriticityModel>> GetLogCriticity();
        Task<List<LogCriticityModel>> GetLogCriticityByFilters(LogCriticityModel filters);
        Task<bool> AddLogCriticityList(List<LogCriticityEntity> logCriticities);
    }
}