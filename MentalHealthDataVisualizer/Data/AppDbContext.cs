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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AmiPrevalence>().ToTable("ami_prevalence");

            base.OnModelCreating(modelBuilder);
        }
    }
}