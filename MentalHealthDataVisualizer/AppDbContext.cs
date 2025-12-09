using Microsoft.EntityFrameworkCore;
using MentalHealthDataVisualizer.Models;

namespace MentalHealthDataVisualizer
{
    public class AppDbContext : DbContext
    {
        // DbSet corresponds to your SQL table
        public DbSet<AmiPrevalence> AmiPrevalence { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
