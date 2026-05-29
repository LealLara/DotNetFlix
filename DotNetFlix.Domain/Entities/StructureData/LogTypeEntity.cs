namespace DotNetFlix.Domain.Entities.StructureEntity
{
    public class LogTypeEntity
    {
        public int IdLogType { get; private set; }
        public string LogTypeMessage { get; private set; }
        public float Criticity { get; private set; } 
        public string LogTypeDescriprion { get; private set; }

        public LogTypeEntity() { }
        public LogTypeEntity(int id, string logTypeMessage, float criticity, string logTypeDescription)
        {
            IdLogType = id;
            LogTypeMessage = logTypeMessage;
            Criticity = criticity;
            LogTypeDescriprion = logTypeDescription ;
        }
        public LogTypeEntity(string logTypeMessage)
        {
            LogTypeMessage = logTypeMessage;
        }
        public LogTypeEntity(string logTypeMessage, float criticity, string logTypeDescription)
        {
            LogTypeMessage = logTypeMessage;
            Criticity = criticity;
            LogTypeDescriprion = logTypeDescription;
        }
        public LogTypeEntity(string logTypeMessage,  string logTypeDescription)
        {
            LogTypeMessage = logTypeMessage;
            LogTypeDescriprion = logTypeDescription;
        }
    }
}