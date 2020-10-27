using Sample.Clean.Core.Infrastructure.Entities.Student;
using Sample.Clean.Core.Infrastructure.Repositories;

namespace Sample.Clean.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public int AddStudent(StudentEntity student)
        {
            return 1; // ID
        }
    }
}