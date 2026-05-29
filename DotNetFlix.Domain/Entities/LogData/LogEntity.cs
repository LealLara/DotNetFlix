namespace DotNetFlix.Domain.Entities.Log
{
    public class LogEntity
    {
        public int LogId { get; private set; }
        public int LogTypeId { get; private set; }
        public string LogMessage { get; private set; }
        public DateTime CreatedAt { get; private set; }


        public LogEntity() { }
        public LogEntity(int logTypeId, string logMessage, DateTime createdAt)
        {
            LogTypeId = logTypeId;
            LogMessage = logMessage;
            CreatedAt = createdAt;
        }
        public LogEntity(int logId, int logTypeId, string logMessage, DateTime createdAt)
        {
            LogId = logId;
            LogTypeId = logTypeId;
            LogMessage = logMessage;
            CreatedAt = createdAt;
        }
    }
}