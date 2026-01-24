namespace KidsEnglishQuiz.Api.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public int DurationMinutes { get; set; }

        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
