namespace DotNetFlix.Domain.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string VideoName { get; set; } = string.Empty;

        public User User { get; set; }
    }
}