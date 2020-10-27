using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Sample.Clean.Api.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        private readonly ILogger<ExceptionHandlerMiddleware> _logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context, IHostingEnvironment env)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                if (!context.Response.HasStarted)
                    await HandleExceptionAsync(context, ex, env);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception, IHostingEnvironment env)
        {
            var code = HttpStatusCode.InternalServerError;
            var message = exception.Message;

            code = exception switch
            {
                NotImplementedException _ => HttpStatusCode.NotImplemented,
                _ => code
            };

            _logger.LogError("Error occured while processing request: {error}", message);


            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return Task.CompletedTask;
        }
    }
}