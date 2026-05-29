using DotNetFlix.Domain.Constants;
using DotNetFlix.Domain.Entities.LogData;
using DotNetFlix.Domain.Entities.StructureEntity;

namespace DotNetFlix.Domain.Models.Structure
{
    public class LogTypeModel
    {
        public int IdLogType { get; private set; }
        public int LogCriticityId { get; private set; }
        public string LogTypeMessage { get; private set; }
        public string LogTypeDescriprion { get; private set; }

        public LogTypeModel() { }
        public LogTypeModel(int idLogType, int criticityId, string logTypeMessage, string logTypeDescriprion)
        {
            IdLogType = idLogType;
            LogCriticityId = criticityId;
            LogTypeMessage = logTypeMessage;
            LogTypeDescriprion = logTypeDescriprion;
        }
        public LogTypeModel(int criticityId, string logTypeMessage, string logTypeDescriprion)
        {
            LogCriticityId = criticityId;
            LogTypeMessage = logTypeMessage;
            LogTypeDescriprion = logTypeDescriprion;
        }

        public IEnumerable<LogTypeEntity> CreatePatternLogTypeEntityList()
        {
                (string logTypeMessage, string logTypeDescription)[] logTypes =
            [
                (
                   PatternAssets.FifthPatternLogType,
                   PatternAssets.FifthPatternLogTypeDescription
                ),
                (
                   PatternAssets.SecondPatternLogType,
                   PatternAssets.SecondPatternLogTypeDescription
                ),
                (
                   PatternAssets.ThirdPatternLogType,
                   PatternAssets.ThirdPatternLogTypeDescription
                )
            ];

            return logTypes.Select(x => new LogTypeEntity(
                logTypeMessage: x.logTypeMessage,
                logTypeDescription: x.logTypeDescription
            ));  
        }
    }
}