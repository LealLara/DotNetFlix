namespace DotNetFlix.Domain.Entities.LogData
{
    public class LogCriticityEntity
    {
        public int LogCriticityId { get; private set; }
        public string LogCriticity { get; private set; }
        public string LogCriticityDescription { get; private set; }

        public LogCriticityEntity() { }
        public LogCriticityEntity(int logCriticityId, string logCriticity, string logCriticityDescription)
        {
            LogCriticityId = logCriticityId;
            LogCriticity = logCriticity;
            LogCriticityDescription = logCriticityDescription;
        }
        public LogCriticityEntity(string logCriticity, string logCriticityDescription)
        {
            LogCriticity = logCriticity;
            LogCriticityDescription = logCriticityDescription;
        }
    }
}