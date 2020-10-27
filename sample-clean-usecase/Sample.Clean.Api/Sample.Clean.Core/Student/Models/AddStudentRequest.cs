namespace Sample.Clean.Core.Student.Models
{
    public class AddStudentRequest
    {
        public AddStudentRequest()
        {

        }

        public AddStudentRequest(string firstName, string lastName, string email, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Grade { get; set; }
    }
}