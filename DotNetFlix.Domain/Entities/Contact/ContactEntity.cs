using DotNetFlix.Domain.Entities.StructureEntity;

namespace DotNetFlix.Domain.Entities.Contact
{
    public class ContactEntity : BaseEntity
    {
        public ContactEntity() { }
        public int ContactId { get; private set; }
        public int UserId { get; private set; }
        public int ContactRoleId { get; private set; }
        public string Contact { get; private set; }
        public string ContactNote { get; private set; }
    }
}