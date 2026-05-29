using DotNetFlix.Domain.Entities.LogData;
using DotNetFlix.Domain.Models.Structure;

namespace DotNetFlix.Domain.Entities.Access
{
    public static class ModelFactory
    {
        public static List<LogCriticityModel> CreateLogCriticityModel(
        IQueryable<LogCriticityEntity> logCriticities)
        {
            return logCriticities.Select(data => new LogCriticityModel(
                    data.LogCriticityId,
                    data.LogCriticity,
                    data.LogCriticityDescription
            )).ToList();
        }








    }
}