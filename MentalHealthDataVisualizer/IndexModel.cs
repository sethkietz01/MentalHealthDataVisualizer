using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MentalHealthDataVisualizer.Data;
using MentalHealthDataVisualizer.Models;

namespace MentalHealthDataVisualizer.Pages
{
    // The name 'IndexModel' must match the @model directive in your .cshtml file
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        // 1. Public property to hold the data
        [BindProperty]
        public IList<AmiPrevalence> AmiPrevalenceData { get; set; } = default!;

        // 2. Inject DbContext in the constructor
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        // 3. Fetch data in the OnGetAsync handler
        public async Task OnGetAsync()
        {
            // Use EF Core to query the DbSet and load data
            AmiPrevalenceData = await _context.AmiPrevalence.ToListAsync();
        }
    }
}