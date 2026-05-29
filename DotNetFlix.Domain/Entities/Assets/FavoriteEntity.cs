using DotNetFlix.Domain.Entities.StructureEntity;

namespace DotNetFlix.Domain.Entities.Assets
{
    public class FavoriteEntity : BaseEntity
    {
        public int UserId { get; private set; }

        public int VideoId { get; private set; }  

        protected FavoriteEntity() { }

        public FavoriteEntity(int  userId,int videoId)
        {
            UserId = userId;
            VideoId = videoId;
        }
    }
}