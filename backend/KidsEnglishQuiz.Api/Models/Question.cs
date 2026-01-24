namespace KidsEnglishQuiz.Api.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } = null!;

        public ICollection<Option> Options { get; set; } = new List<Option>();
        public ICollection<QuestionTag> QuestionTags { get; set; } = new List<QuestionTag>();
    }
}
