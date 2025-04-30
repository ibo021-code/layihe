using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proniaa.DAL;
using Proniaa.Models;
using Proniaa.ViewModels;

using Microsoft.EntityFrameworkCore;
namespace Proniaa.Controllers
{

    public class HomeController(AppDbContext _context) : Controller
    {


        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Slides = _context.Slides
                .OrderBy(s => s.Order)
                .Take(2)
                .ToList(),
                Products = _context.Products
                .Take(8)
                .Include(p => p.ProductImages.Where(x => x.IsPrimary != null))
                .ToList()


            };

            return View(homeVM);
        }

    }
}
