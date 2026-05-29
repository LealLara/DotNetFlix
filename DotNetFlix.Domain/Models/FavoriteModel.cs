namespace DotNetFlix.Domain.Models
{
    public class FavoriteModel : BaseModel
    { 

        public int UserId { get; set; }

        public string VideoName { get; set; } = string.Empty;

        public UserModel User { get; set; }
    }
}