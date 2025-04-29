using Microsoft.EntityFrameworkCore;
using Proniaa.Models;

namespace Proniaa.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slide> Slides { get; set; }
    }
}