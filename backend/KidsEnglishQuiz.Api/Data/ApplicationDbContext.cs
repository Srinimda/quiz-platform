using Microsoft.EntityFrameworkCore;
using KidsEnglishQuiz.Api.Models;

namespace KidsEnglishQuiz.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Quiz> Quizzes => Set<Quiz>();
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<Option> Options => Set<Option>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<ConceptLevel> ConceptLevels => Set<ConceptLevel>();
        public DbSet<QuestionTag> QuestionTags => Set<QuestionTag>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionTag>()
                .HasKey(qt => new { qt.QuestionId, qt.TagId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
