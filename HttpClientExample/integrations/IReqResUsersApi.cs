using HttpClientExample.models;
using HttpClientExample.models.ReqRes.HttpClientExample.models.MyIp;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientExample.integrations
{


    public interface IReqResUsersApi
    {

        [Get(ApiEndpoints.ReqResUsers.GetAll)]
        Task<UserListResponse> GetAllAsync();

        //[Authorize("Bearer")]
        [Headers("x-api-key")]
        [Get(ApiEndpoints.ReqResUsers.GetById)]
        Task<UserResponse> GetByIdAsync(int id, [Header("x-api-key")] string apiKey);

        //[Headers("x-api-key")]
        //[Post(ApiEndpoints.ReqResUsers.Create)]
        //Task<UserResponse> PostAsync(UserDataRequest data, [Header("x-api-key")] string apiKey);
    }
}
