using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOE3MaterialVerwaltung.Data;
using SOE3MaterialVerwaltung.Models;
using System.Diagnostics;

namespace SOE3MaterialVerwaltung.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Materials.Include(x => x.Materialgruppe).ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Materialgruppe()
        {
            var model = new MaterialgruppeViewModel()
            {
                MaterialgruppeList = _context.Materialgruppe.ToList()
            };
            return View(model);
        }

        public IActionResult Statistik()
        {
            var model = new StatistikViewModel()
            {
                MaterialgruppeList = _context.Materialgruppe.ToList(),
                MaterialList = _context.Materials.ToList()
            };
            return View(model);
        }

        
    }
}