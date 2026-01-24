namespace KidsEnglishQuiz.Api.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public string? School { get; set; }
        public string? Country { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
