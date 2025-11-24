using Microsoft.EntityFrameworkCore;
using JobTrackerApp.Models;

namespace JobTrackerApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<JobApplication> JobApplications { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
