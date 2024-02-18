using App.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movie.Include(m => m.Cinema).OrderBy(m => m.Name).ToListAsync();
            return View(allMovies);    
        }
    }
}
