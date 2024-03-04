using Microsoft.EntityFrameworkCore;

namespace firstApp.Models
{
    public class AppdbContext : DbContext

    {
        public AppdbContext(DbContextOptions options) :
            base(options)
        { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre>? genres { get; set; }

    }
}
