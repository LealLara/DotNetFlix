using DotNetFlix.Domain.Entities.StructureEntity;

namespace DotNetFlix.Domain.Entities.Access
{
    public class LoginEntity: BaseEntity
    {
        public LoginEntity() { }

        public int LoginId { get; private set; }
        public string NickName { get; private set; }
        public string Password { get; private set; }
        
        public LoginEntity(string nickName, string password)
        {
            NickName = nickName;
            Password = password;
        }
        public LoginEntity(int id)
        {
            LoginId = id; 
        }
        public LoginEntity(int id, string password)
        {
            LoginId = id; 
            Password = password;
        }
        public LoginEntity(int id, bool isActive)
        {
            LoginId = id; 
            Active = isActive;
        }
        public LoginEntity(int id, DateTime updatedAt)
        {
            LoginId = id; 
            UpdatedAt = updatedAt;
        }
    }
}