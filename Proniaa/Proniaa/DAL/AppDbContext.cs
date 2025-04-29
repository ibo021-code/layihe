using Microsoft.EntityFrameworkCore;

namespace Proniaa.DAL
{
    public class AppDbContext : DbContext
    {
        internal object slides;

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public object Slides { get; internal set; }
    }
}