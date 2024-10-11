using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging; // Add this if not already present

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; } // DbSet predstavlja tablicu u bazi podataka (DiaryEntries je ime tablice)

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went Hiking",
                    Content = "Went hiking with Joe!",
                    Created = DateTime.Now // Moglo se i sa DateTime.Today da se izbjegne greška tijekom migracije u bazi podataka
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went Shopping",
                    Content = "Went shopping with Joe!",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Diving",
                    Content = "Went diving with Joe!",
                    Created = DateTime.Now
                }
            );
        }

    }
}
