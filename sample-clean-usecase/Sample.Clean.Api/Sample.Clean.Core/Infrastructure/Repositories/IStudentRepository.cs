using Sample.Clean.Core.Infrastructure.Entities.Student;

namespace Sample.Clean.Core.Infrastructure.Repositories
{
    public interface IStudentRepository
    {
        int AddStudent(StudentEntity student);
    }
}