using System;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Sample.Clean.Api.Controllers
{
    [ApiController]
    [ApiVersionNeutral]
    [Route("version")]
    public class VersionController : ControllerBase
    {
        /// <summary>
        /// Get version
        /// </summary>
        [HttpGet]
        [SwaggerOperation("get")]
        [SwaggerResponse(200, Description = "Returns API version", Type = typeof(string))]
        public IActionResult Get()
        {
            var buildId = Environment.GetEnvironmentVariable("VERSION_ID");
            return Ok(!string.IsNullOrWhiteSpace(buildId) ? buildId : "dev");
        }
    }
}