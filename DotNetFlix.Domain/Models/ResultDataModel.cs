namespace DotNetFlix.Domain.Models
{
    public class ResultDataModel
    {
        public bool Success { get; private set; }
        public string Message { get; private set; } = string.Empty;
        public List<object> Data { get; private set; } = new List<object>();

        public ResultDataModel(){}
        public ResultDataModel(bool success, string message, List<object> data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}