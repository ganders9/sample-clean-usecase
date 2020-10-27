using Newtonsoft.Json;

namespace Sample.Clean.Api.Common
{
    public interface IBaseResponse
    {
        /// <summary>The status code of the response.</summary>
        [JsonProperty("status")]
        int Status { get; set; }
    }
}