using Microsoft.Extensions.DependencyInjection;
using Sample.Clean.Application.UseCases.Student;
using Sample.Clean.Core.Student.UseCases;

namespace Sample.Clean.Application
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // Student
            services.AddScoped<IAddStudentUseCase, AddStudentUseCase>();
        }
    }
}