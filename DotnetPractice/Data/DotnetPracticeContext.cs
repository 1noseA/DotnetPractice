using Microsoft.EntityFrameworkCore;

namespace DotnetPractice.Data
{
    public class DotnetPracticeContext : DbContext
    {
        public DotnetPracticeContext (DbContextOptions<DotnetPracticeContext> options)
            : base(options)
        {
        }

        public DbSet<DotnetPractice.Models.Student> Student { get; set; } = default!;

        public DbSet<DotnetPractice.Models.Enrollment> Enrollment { get; set; } = default!;

        public DbSet<DotnetPractice.Models.Course> Course { get; set; } = default!;

    }
}
