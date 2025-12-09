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

        public async Task<IActionResult> Index() // Use the async method
        {
            // Fetch all records from the AmiPrevalence table asynchronously
            List<AmiPrevalence> amiPrevalences = await _context.AmiPrevalence.ToListAsync();

            // Pass the List<AmiPrevalence> to the Index View
            return View(amiPrevalences);
        }

        // Remove the empty Index() method:
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
    }
}