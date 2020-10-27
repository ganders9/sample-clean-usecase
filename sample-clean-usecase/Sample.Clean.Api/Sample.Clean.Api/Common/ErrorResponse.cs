using Newtonsoft.Json;

namespace Sample.Clean.Api.Common
{
    public class ErrorResponse<T> : IBaseResponse where T : class
    {
        /// <summary>
        /// The status code of the error response.
        /// Should be set to the same value as corresponding http status code returned from the controller.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }


        /// <summary>
        /// The detailed error data of the response.
        /// The generic type indicated the type used for error detailed information.
        /// </summary>
        [JsonProperty("error")]
        public ErrorData<T> Error { get; set; }
    }

    /// <summary>
    /// Represents the basic error response
    /// </summary>
    public class ErrorResponse : IBaseResponse
    {
        /// <summary>
        /// The status code of the error response.
        /// Should be set to the same value as corresponding http status code returned from the controller.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>The error data of the response.</summary>
        [JsonProperty("error")]
        public ErrorData Error { get; set; }
    }
}