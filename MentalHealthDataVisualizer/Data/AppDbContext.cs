using Microsoft.EntityFrameworkCore;
using MentalHealthDataVisualizer.Models;

namespace MentalHealthDataVisualizer.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<AmiPrevalence> AmiPrevalence { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Add this method to override the default naming convention
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Explicitly map the C# model to the correct table name in the database
            modelBuilder.Entity<AmiPrevalence>().ToTable("ami_prevalence");

            // You may also need to call the base implementation if you have complex setup
            base.OnModelCreating(modelBuilder);
        }
    }
}