using STW.SurveyAppWithMVCBlazer.Models;

namespace STW.SurveyAppWithMVCBlazer.Services
{
    public interface IQuestionService
    {
        /// <summary>
        /// Fetchs Questions along with the Answers
        /// </summary>
        /// <returns></returns>
      public List<Question> GetQuestions();
    }
}
