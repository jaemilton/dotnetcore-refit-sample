using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientExample.models.ReqRes
{
    namespace HttpClientExample.models.MyIp
    {

        public class PaginationResponse
        {
            public int Page { get; set; }
            public int Per_Page { get; set; }
            public int Total { get; set; }
            public int Total_Pages { get; set; }
        }
        public class UserListResponse : PaginationResponse 
        {
            public List<UserData> Data { get; set; }
        }

        public class UserResponse
        {
            public UserData Data { get; set; }
        }

        public class UserDataRequest
        {
            public string Email { get; set; }
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Avatar { get; set; }
        }
        public class UserData : UserDataRequest
        {
            public int Id { get; set; }
        }
    }
}
