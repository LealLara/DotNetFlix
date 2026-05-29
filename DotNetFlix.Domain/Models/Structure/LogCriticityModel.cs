using DotNetFlix.Domain.Constants;
using DotNetFlix.Domain.Entities.LogData;

namespace DotNetFlix.Domain.Models.Structure
{
    public class LogCriticityModel
    {
        public int LogCriticityId { get; private set; }
        public string LogCriticity { get; private set; }
        public string LogCriticityDescription { get; private set; }

        public LogCriticityModel() { }

        public LogCriticityModel(int logCriticityId, string logCriticity, string logCriticityDescription):this()
        {
            LogCriticityId = logCriticityId;
            LogCriticity = logCriticity;
            LogCriticityDescription = logCriticityDescription;
        }
        public LogCriticityModel(string logCriticity, string logCriticityDescription)
        {
            LogCriticity = logCriticity;
            LogCriticityDescription = logCriticityDescription;
        }


        public List<LogCriticityEntity> CreatePatternLogCriticityEntityList()
        {
            (string Criticity, string Description)[] criticities =
            [
                (
                   PatternAssets.FirstPatternLogCriticity,
                   PatternAssets.FirstPatternLogCriticityDescription
                ),
                (
                   PatternAssets.SecondPatternLogCriticity,
                   PatternAssets.SecondPatternLogCriticityDescription
                ),
                (
                   PatternAssets.ThirdPatternLogCriticity,
                   PatternAssets.ThirdPatternLogCriticityDescription
                )
            ];

            return criticities.Select(x => new LogCriticityEntity(
                logCriticity: x.Criticity,
                logCriticityDescription: x.Description
            )).ToList();

        }
        public LogCriticityEntity CreateAddLogCriticityEntity()
        {
            return new(
                logCriticity: LogCriticity,
                logCriticityDescription: LogCriticityDescription
            );
        }
        public IEnumerable<LogCriticityEntity> CreateAddLogCriticityEntityList()
        {
            return new List<LogCriticityEntity> {
            new (
                logCriticity : LogCriticity,
                logCriticityDescription : LogCriticityDescription
            )};
        }

        public LogCriticityEntity CreateAlterLogCriticityEntity()
        {
            return new(
                logCriticityId: LogCriticityId,
                logCriticity: LogCriticity,
                logCriticityDescription: LogCriticityDescription
            );
        }
    }
}