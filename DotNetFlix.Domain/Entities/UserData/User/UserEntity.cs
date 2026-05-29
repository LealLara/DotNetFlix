using DotNetFlix.Domain.Entities.StructureEntity;

namespace DotNetFlix.Domain.Entities.UserData.User
{
    public class UserEntity : BaseEntity
    {
        public int LoginId { get; private set; }
        public string UserName { get; private set; }

        protected UserEntity() { }

        public UserEntity(string name, int loginId)
        {
            UserName = name;
            LoginId = loginId;
        }
        public UserEntity(int id, string name, int loginId)
        {
            LoginId = id;
            UserName = name;
            LoginId = loginId;
        }
        public UserEntity(string name)
        {
            UserName = name;
        }
        public UserEntity(int id)
        {
            LoginId = id;
        }
    }
}