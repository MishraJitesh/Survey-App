using Microsoft.EntityFrameworkCore;
using STW.SurveyAppWithMVCBlazer.DatabaseContext;
using STW.SurveyAppWithMVCBlazer.Models;

namespace STW.SurveyAppWithMVCBlazer.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly ApplicationContext _context;
        public QuestionService(ApplicationContext context)
        {
           _context = context;
        }
        public List<Question> GetQuestions() => _context.Questions.Include(x => x.Answers).ToList();
    }
}
