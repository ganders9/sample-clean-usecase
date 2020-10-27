using System.Net.Http;
using System.Threading.Tasks;
using Sample.Clean.Core.Common;

namespace Sample.Clean.Infrastructure.Common
{
    internal class HttpClientWrapper : IHttpClientWrapper
    {
        private static readonly HttpClient _httpClient;

        static HttpClientWrapper()
        {
            _httpClient = new HttpClient();
        }

        public Task<HttpResponseMessage> PostAsync(string uri, HttpContent content)
        {
            return _httpClient.PostAsync(uri, content);
        }

        public Task<HttpResponseMessage> GetAsync(string uri)
        {
            return _httpClient.GetAsync(uri);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return _httpClient.SendAsync(request);
        }
    }
}