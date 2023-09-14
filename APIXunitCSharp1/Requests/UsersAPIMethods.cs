using APITestProject.common;
using APITestProject.Response;
using APIXunitCSharp1.common;
using APIXunitCSharp1.Requests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APITestProject.Requests
{
    public class UsersAPIMethods : BaseClient, IUsersAPIMethods
    {
        public UsersAPIMethods(string baseUrl) : base(baseUrl)
        {

        }
        public RestResponse<AllUsersResponse> GetUsers(string endpoint)
        {
            var request = base.GetRequest(endpoint);
            var response = base.GetResponse<AllUsersResponse>(request);
            return response;
        }

        public RestResponse<AddUserResponse> CreateUsers(string endpoint, string payload)
        {
            var request = base.PostRequest(endpoint, payload);
            var response = base.GetResponse<AddUserResponse>(request);           
            return response;
        }
    }
}
