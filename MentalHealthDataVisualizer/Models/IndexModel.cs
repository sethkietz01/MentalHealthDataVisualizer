using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MentalHealthDataVisualizer.Data;

namespace MentalHealthDataVisualizer.Models
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