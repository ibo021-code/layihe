using Microsoft.AspNetCore.Mvc;
using Proniaa.DAL;
using Proniaa.Models;
using Proniaa.ViewModels;

namespace Proniaa.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Slide> slides = new List<Slide>
            {
                new Slide()
                {

                    Title = "basliq 1",
                    SubTitle = "komekci basliq 1",
                    Description = "ag qara qirmizi can ay fransiz qizi",
                    Image = "1-2-524x617.png",
                    Order = 3
                },
                new Slide()
                {

                    Title = "basliq 2",
                    SubTitle = "komekci basliq 2",
                    Description = "ne ekersen onu bicersen",
                    Image = "gedbeey.jpg",
                    Order = 1
                },
                new Slide()
                {

                    Title = "basliq 3",
                    SubTitle = "komekci basliq 3",
                    Description = "tek elden ses cixmaz",
                    Image = "bdu.jpeg",
                    Order = 2
                },

            };
            _context.Slides.AddRange(slides);
            _context.SaveChanges();
            HomeVM homeVM = new HomeVM
            {
                Slides = slides.OrderBy(s => s.Order).ToList()
            };


            return View(homeVM);
        }
    }
}
