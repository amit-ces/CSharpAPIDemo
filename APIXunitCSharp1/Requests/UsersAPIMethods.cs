using APITestProject.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestProject.Requests
{
    public class UsersAPIMethods
    {
        public AllUsersResponse GetUsers()
        {
            var restClient = new RestClient("https://reqres.in/");
            var restRequest = new RestRequest("api/users?page=2", Method.Get);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<AllUsersResponse>(content);
            return users;
        }

        
    }
}
