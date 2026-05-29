using DotNetFlix.Domain.Entities.StructureEntity;
using DotNetFlix.Domain.Entities.UserData.User;

namespace DotNetFlix.Domain.Entities.Assets
{
    public class PlaylistEntity : BaseEntity
    {
        public int UserId { get; private set; }

        public int VideoId { get; private set; }

        public int Position { get; private set; }

        public UserEntity User { get; private set; }

        public VideoEntity Video { get; private set; }

        protected PlaylistEntity() { }

        public PlaylistEntity(
            int userId,
            int videoId,
            int position)
        {
            UserId = userId;
            VideoId = videoId;
            Position = position;
        }
    }
}