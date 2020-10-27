using System.Net;
using System.Threading.Tasks;
using Sample.Clean.Core.Infrastructure.Entities.Student;
using Sample.Clean.Core.Infrastructure.Repositories;
using Sample.Clean.Core.Student.Models;
using Sample.Clean.Core.Student.UseCases;

namespace Sample.Clean.Application.UseCases.Student
{
    public class AddStudentUseCase : IAddStudentUseCase
    {
        private readonly IStudentRepository _repository;

        public AddStudentUseCase(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddStudentResponse> ExecuteAsync(AddStudentRequest request)
        {
            var id = _repository.AddStudent(new StudentEntity
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Grade = request.Grade
            });
            
            if (id > 0) return new AddStudentResponse(true, "Student added", HttpStatusCode.Accepted);

            return new AddStudentResponse(false, "Add Student Failed", HttpStatusCode.BadRequest);
        }
    }
}