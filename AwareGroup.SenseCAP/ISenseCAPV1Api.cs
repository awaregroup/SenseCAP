using AwareGroup.SenseCAP.Models;
using Refit;
using System.Threading.Tasks;

namespace AwareGroup.SenseCAP
{
    public interface ISenseCAPV1Api : ISenseCAPApi
    {
        [Get("1.0/lists/gateway")]
        Task<ApiResult<PagedData<Gateway>>> GetGateways();

        [Get("1.0/lists/node")]
        Task<ApiResult<PagedData<Node>>> GetNodes();
    }
}
