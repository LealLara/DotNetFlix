namespace DotNetFlix.Domain.Entities.StructureEntity
{
    public abstract class BaseEntity
    { 
        public DateTime CreatedAt { get; protected set; }
        public bool Active { get; protected set; }
        public DateTime UpdatedAt { get; protected set; } = DateTime.Now;

        protected BaseEntity()
        {
            CreatedAt = CreatedAt;
            Active = Active;
        }

        protected BaseEntity(DateTime dateTime, bool flagupdate)
        { 
            if (flagupdate)
                UpdatedAt = dateTime;

            else
                CreatedAt = dateTime;
        } 
        protected BaseEntity( bool active)
        { 
            Active = active; 
        } 
    }
}