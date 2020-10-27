using System.Threading.Tasks;
using Moq;
using Sample.Clean.Application.UseCases.Student;
using Sample.Clean.Core.Infrastructure.Entities.Student;
using Sample.Clean.Core.Infrastructure.Repositories;
using Sample.Clean.Core.Student.Models;
using Xunit;

namespace Sample.Clean.Tests.Application.UseCases.Student
{
    public class AddStudentUseCaseTests
    {

        [Fact]
        public async Task AddStudentUseCaseTest_Success()
        {
            var studentRepo = new Mock<IStudentRepository>();
            studentRepo.Setup(x => x.AddStudent(It.IsAny<StudentEntity>())).Returns(1);
            var addStudentUseCase = new AddStudentUseCase(studentRepo.Object);

            var result = await addStudentUseCase.ExecuteAsync(new AddStudentRequest("Tester", "Testersson", "test@test.se", 3));
            Assert.True(result.Success);
        }
    }
}