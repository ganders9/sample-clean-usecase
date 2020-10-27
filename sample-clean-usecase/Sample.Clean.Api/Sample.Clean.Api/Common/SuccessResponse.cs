using Newtonsoft.Json;

namespace Sample.Clean.Api.Common
{
    public class SuccessResponse<T> : IBaseResponse where T : class
    {
        private const int DefaultStatusValue = 200;

        /// <summary>
        /// The status code of the successful response.
        /// Should be set to the same value as corresponding http status code returned from the controller.
        /// Default value is 200.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; } = 200;

        /// <summary>The actual data returned in the response.</summary>
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}