using DotNetFlix.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetFlix.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<PlaylistItem> PlaylistItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}