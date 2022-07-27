using Microsoft.EntityFrameworkCore;
using STW.SurveyAppWithMVCBlazer.Models;

namespace STW.SurveyAppWithMVCBlazer.DatabaseContext
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
