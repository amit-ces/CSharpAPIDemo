using APITestProject.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIXunitCSharp1.Requests
{
    public interface IUsersAPIMethods
    {
        RestResponse<AllUsersResponse> GetUsers(string endpoint);
        RestResponse<AddUserResponse> CreateUsers(string endpoint, string payload);
    }
}
