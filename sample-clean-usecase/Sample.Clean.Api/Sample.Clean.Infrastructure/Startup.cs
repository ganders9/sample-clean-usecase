using Microsoft.Extensions.DependencyInjection;
using Sample.Clean.Core.Common;
using Sample.Clean.Core.Infrastructure.Repositories;
using Sample.Clean.Infrastructure.Common;
using Sample.Clean.Infrastructure.Repositories;

namespace Sample.Clean.Infrastructure
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IHttpClientWrapper, HttpClientWrapper>()
                .AddScoped<IStudentRepository, StudentRepository>();
        }
    }
}