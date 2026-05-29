namespace DotNetFlix.Domain.Models
{
    public class UserModel
    {
        public int UserId { get; private set; }
        public int LoginId { get; private set; }
        public string UserName { get; private set; }
        public DateTime Birthday { get; private set; }

        protected UserModel() { }
        
        public UserModel(int id, string name, int loginId, DateTime birthday)
        {
            UserId = id;
            UserName = name;
            LoginId = loginId;
            Birthday = birthday;
        }
        public UserModel(string name, int loginId, DateTime birthday)
        { 
            UserName = name;
            LoginId = loginId;
            Birthday = birthday;
        }
        public UserModel(string name)
        {
            UserName = name;
        }
        public UserModel(int id)
        {
            UserId = id;
        }
    }
}