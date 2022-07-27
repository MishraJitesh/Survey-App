namespace STW.SurveyAppWithMVCBlazer.Models
{
    public class Question: BaseModel
    {
        public Question()
        {
        }
        public Question(int id,string text, int order):base(id)
        {
            this.Text = text;
            this.Order = order;
        }
        public string? Text { get; set; }
        public int Order { get; set; }
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
