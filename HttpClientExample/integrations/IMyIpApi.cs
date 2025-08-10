using HttpClientExample.models.MyIp;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientExample.integrations
{
    public interface IMyIpApi
    {
        [Get(ApiEndpoints.MyIp.GetMyIp)]
        Task<MyIpResponse> GetMyIpAsync();

       

    }
}
