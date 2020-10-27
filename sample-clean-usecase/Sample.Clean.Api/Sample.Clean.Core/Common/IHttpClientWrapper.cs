using System.Net.Http;
using System.Threading.Tasks;

namespace Sample.Clean.Core.Common
{
    public interface IHttpClientWrapper
    {
        Task<HttpResponseMessage> PostAsync(string uri, HttpContent content);
        Task<HttpResponseMessage> GetAsync(string uri);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    }
}