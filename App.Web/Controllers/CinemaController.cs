using App.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _context;

        public CinemaController(AppDbContext context)
        {
            _context = context;
        }
      

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinema.ToListAsync();
            return View(allCinemas);
        }
    }
}
