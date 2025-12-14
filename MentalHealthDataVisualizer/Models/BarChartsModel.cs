using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MentalHealthDataVisualizer.Data;

namespace MentalHealthDataVisualizer.Models
{
    public class BarChartsModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public IList<AmiPrevalence> AmiPrevalenceData { get; set; } = default!;

        public BarChartsModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            if (_context.AmiPrevalence != null)
                AmiPrevalenceData = await _context.AmiPrevalence.ToListAsync();
        }
    }
}
