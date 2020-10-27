using System.Threading.Tasks;

namespace Sample.Clean.Core.Common
{
    public interface IUseCase<in TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }

    public interface IUseCase<in TRequest>
    {
        Task ExecuteAsync(TRequest request);
    }
}