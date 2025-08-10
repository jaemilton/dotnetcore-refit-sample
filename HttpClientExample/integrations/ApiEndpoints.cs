using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientExample.integrations
{
    public class ApiEndpoints
    {
        public static class MyIp
        {
            public const string ApiBase = "/v2";
            public const string GetMyIp = $"{ApiBase}/ip.json";
        }

        public static class ReqResUsers
        {
            public const string ApiBase = "/api";
            public const string Base = $"{ApiBase}/users";
            public const string GetAll = $"{Base}";
            public const string GetById = $"{Base}/{{id}}";
            //public const string Create = Base;
        }
     

    }
}
