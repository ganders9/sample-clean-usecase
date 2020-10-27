using System.Net;

namespace Sample.Clean.Core.Student.Models
{
    public class AddStudentResponse
    {
        public bool Success { get; }
        public string Message { get; }
        public HttpStatusCode StatusCode { get; }

        public AddStudentResponse(
            bool success,
            string message,
            HttpStatusCode statusCode)
        {
            Success = success;
            Message = message;
            StatusCode = statusCode;
        }
    }
}