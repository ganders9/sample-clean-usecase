using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sample.Clean.Api.Common
{
    /// <summary>Represents the error data with detailed information.</summary>
    /// <typeparam name="T"></typeparam>
    public class ErrorData<T> : ErrorData where T : class
    {
        /// <summary>The collection of error details.</summary>
        /// <value>The detail.</value>
        [JsonProperty("detail")]
        public ICollection<T> Detail { get; set; }
    }

    public class ErrorData
    {
        /// <summary>The error message.</summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>The error description.</summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}