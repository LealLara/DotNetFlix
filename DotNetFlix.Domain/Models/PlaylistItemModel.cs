namespace DotNetFlix.Domain.Models
{
    public class PlaylistItemModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string VideoName { get; set; } = string.Empty;

        public int Order { get; set; }

        public UserModel User { get; set; }
    }
}