using FinalArizon.DAL;
using FinalArizon.Models;
using FinalArizon.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FinalArizon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

   

        public IActionResult Index()
        {
            List<Category> categories =  _appDbContext.Categories.Include(s => s.Products).ToList();

            return View(categories);
        }
    }
}