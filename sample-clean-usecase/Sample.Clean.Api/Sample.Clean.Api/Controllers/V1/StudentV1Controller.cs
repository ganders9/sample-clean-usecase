using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.Clean.Api.Common;
using Sample.Clean.Core.Student.Models;
using Sample.Clean.Core.Student.UseCases;
using Swashbuckle.AspNetCore.Annotations;

namespace Sample.Clean.Api.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("student")]
    public class StudentV1Controller : Controller
    {
        private readonly IAddStudentUseCase _addStudentUseCase;

        public StudentV1Controller(IAddStudentUseCase addStudentUseCase)
        {
            _addStudentUseCase = addStudentUseCase;
        }

        /// <summary>
        /// Creates a Student
        /// </summary>
        [HttpPost]
        [SwaggerOperation("postStudent")]
        [SwaggerResponse(201, "Student was successfully created", typeof(SuccessResponse<string>))]
        [SwaggerResponse(400, "Bad request", typeof(ErrorResponse<string>))]
        public async Task<IActionResult> Post([FromBody] AddStudentRequest request)
        {

            var response = await _addStudentUseCase.ExecuteAsync(request);

            if (!response.Success)
            {
                return BadRequest(new ErrorResponse
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Error = new ErrorData<string>
                    {
                        Message = "Bad request",
                        Description = response.Message
                    }
                });
            }

            return Created("", new SuccessResponse<string>
            {
                Status = (int)HttpStatusCode.Created
            });
        }

    }
}