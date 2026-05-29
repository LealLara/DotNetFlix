using DotNetFlix.Domain.Entities.StructureEntity;

namespace DotNetFlix.Domain.Entities.UserData.Contact
{
    public class ContactEntity : BaseEntity
    {
        public ContactEntity() { }
        public int ContactId { get; private set; }
        public int UserId { get; private set; }
        public int ContactRoleId { get; private set; }
        public string ContactData { get; private set; }
        public string ContactName { get; private set; }
        public string ContactNote{ get; private set; } 

        public ContactEntity (int contactId, int userId, int contactRoleId, string contactData, string contactName, string contactNote)
        {
            ContactId = contactId;
            UserId = userId;
            ContactRoleId = contactRoleId;
            ContactData = contactData;
            ContactName = contactName;
            ContactNote = contactNote;
        }   
        public ContactEntity (int userId, int contactRoleId, string contactData, string contactName, string contactNote)
        {
            UserId = userId; 
            ContactRoleId = contactRoleId;
            ContactData = contactData;
            ContactName = contactName;
            ContactNote = contactNote;
        }   
    }
}