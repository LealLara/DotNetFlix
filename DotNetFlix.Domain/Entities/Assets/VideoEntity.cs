using DotNetFlix.Domain.Entities.StructureEntity;

namespace DotNetFlix.Domain.Entities.Assets
{
    public class VideoEntity : BaseEntity
    {
        public string Name { get; private set; }

        public string FilePath { get; private set; }

        public string ThumbnailPath { get; private set; }

        protected VideoEntity() { }

        public VideoEntity(
            string name,
            string filePath,
            string thumbnailPath)
        {
            Name = name;
            FilePath = filePath;
            ThumbnailPath = thumbnailPath;
        }
        public VideoEntity(
            int id,
            string name,
            string filePath,
            string thumbnailPath)
        {
            Id = id;
            Name = name;
            FilePath = filePath;
            ThumbnailPath = thumbnailPath;
        }
    }
}