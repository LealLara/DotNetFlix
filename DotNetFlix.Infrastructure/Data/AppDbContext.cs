using DotNetFlix.Domain.Entities.Assets;
using DotNetFlix.Domain.Entities.LogData;
using DotNetFlix.Domain.Entities.UserData.User;
using Microsoft.EntityFrameworkCore;

namespace DotNetFlix.Infrastructure.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<LogCriticityEntity> LogCriticities { get; set; }

        public DbSet<VideoEntity> Videos { get; set; }

        public DbSet<FavoriteEntity> Favorites { get; set; }

        public DbSet<PlaylistEntity> Playlists { get; set; }

        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}