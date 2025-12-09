using MentalHealthDataVisualizer.Data;
using MentalHealthDataVisualizer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentalHealthDataVisualizer.Controllers
{
    public class AmiPrevalenceController : Controller
    {
        private readonly AppDbContext _context;

        public AmiPrevalenceController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() 
        {
            List<AmiPrevalence> amiPrevalences = await _context.AmiPrevalence.ToListAsync();

            return View(amiPrevalences);
        }
    }
}