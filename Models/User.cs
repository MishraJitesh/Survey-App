namespace STW.SurveyAppWithMVCBlazer.Models
{
    public class User:BaseModel
    {
        public User()
        {
            this.FirstName = "System";
            this.LastName = "Admin";
            this.Email = "System@admin.com";
        }
        public User(int id, string firstName, string lastName, string email):base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int TimeTaken { get; set; }
        public int Score { get; set; }
    }


}
