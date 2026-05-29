namespace DotNetFlix.Domain.Models.Structure
{
    public class BaseModel
    {
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public DateTime UpdatedAt { get; private set; }

    }
}