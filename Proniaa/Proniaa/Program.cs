using Microsoft.EntityFrameworkCore;
using Proniaa.DAL;

namespace Proniaa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer("Server=IBRAHIM\\SQLEXPRESS;database=Proniaa;trusted_connection=true;integrated security=true;TrustServerCertificate=true;");
            }

            );

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                 "default",
                 "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
