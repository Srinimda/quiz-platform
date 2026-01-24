using Microsoft.EntityFrameworkCore;

namespace KidsEnglishQuiz.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets will go here
        // public DbSet<User> Users { get; set; }
    }
}
