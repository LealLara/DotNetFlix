 using Microsoft.EntityFrameworkCore;

namespace DotNetFlix.Infrastructure.Data
{
    public class AppDbContext : DbContext
    { 
       // public DbSet<Movie> Movies { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
    }
}