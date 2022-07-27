using System.ComponentModel.DataAnnotations;

namespace STW.SurveyAppWithMVCBlazer.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
        }
        public BaseModel(int id)
        {
            Id = id;
        }

        [Key]
        public int Id { get; set; }
    }
}
