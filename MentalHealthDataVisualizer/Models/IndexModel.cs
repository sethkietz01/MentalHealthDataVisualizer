using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MentalHealthDataVisualizer.Data;

namespace MentalHealthDataVisualizer.Models
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        // Sorting properties
        public string YearSort { get; set; }
        public string AgeCategorySort { get; set; }
        public string DemographicSort { get; set; }
        public string TallySort { get; set; }
        public string CurrentSort { get; set; }


        [BindProperty]
        public IList<AmiPrevalence> AmiPrevalenceData { get; set; } = default!;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string sortOrder)
        {
            // Set the current sorting order based on the parameter
            CurrentSort = sortOrder;

            // Determine the next sort state for each column
            if (CurrentSort == "Year")
                YearSort = "Year_desc";
            else
                YearSort = "Year";

            if (CurrentSort == "Age")
                AgeCategorySort = "Age_desc";
            else
                AgeCategorySort = "Age";

            if (CurrentSort == "Demo")
                DemographicSort = "Demo_desc";
            else
                DemographicSort = "Demo";

            if (CurrentSort == "Tally")
                TallySort = "Tally_desc";
            else
                TallySort = "Tally";


            // Start query build
            IQueryable<AmiPrevalence> data = _context.AmiPrevalence.AsQueryable();

            // Apply sorting
            switch (sortOrder)
            {
                case "Year_desc":
                    data = data.OrderByDescending(s => s.data_year);
                    break;
                case "Year":
                    data = data.OrderBy(s => s.data_year);
                    break;
                case "Age_desc":
                    data = data.OrderByDescending(s => s.age_category);
                    break;
                case "Age":
                    data = data.OrderBy(s => s.age_category);
                    break;
                case "Demo_desc":
                    data = data.OrderByDescending(s => s.demographic);
                    break;
                case "Demo":
                    data = data.OrderBy(s => s.demographic);
                    break;
                case "Tally_desc":
                    data = data.OrderByDescending(s => s.tally);
                    break;
                case "Tally":
                    data = data.OrderBy(s => s.tally);
                    break;
                default:
                    data = data.OrderBy(s => s.data_year);
                    break;
            }

            // Execute the query
            AmiPrevalenceData = await data.ToListAsync();
        }
    }
}