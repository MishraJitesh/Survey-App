using System.ComponentModel.DataAnnotations.Schema;

namespace STW.SurveyAppWithMVCBlazer.Models
{
    public class Answer: BaseModel
    {
        public Answer()
        {
        }
        public Answer(string text, bool isValidAnswer, int questionId, Question question)
        {
            Text = text;
            IsValidAnswer = isValidAnswer;
            QuestionId = questionId;
            Question = question;
        }

        public string? Text { get; set; }
        public bool IsValidAnswer { get; set; } = false;
        [ForeignKey("QuestionId")]
        public int QuestionId { get; set; }
        public Question Question { get; set; } = new Question();
    }
}
