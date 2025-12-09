using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MentalHealthDataVisualizer.Data;
using MentalHealthDataVisualizer.Models;

namespace MentalHealthDataVisualizer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public IList<AmiPrevalence> AmiPrevalenceData { get; set; } = default!;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            AmiPrevalenceData = await _context.AmiPrevalence.ToListAsync();
        }
    }
}