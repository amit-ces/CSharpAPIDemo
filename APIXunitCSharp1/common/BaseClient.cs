using APITestProject.Response;
using APIXunitCSharp1.common;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APITestProject.common
{
    public abstract class BaseClient: IBaseClient

    {
        private RestClient restClient { get;  set; }
        private RestResponse restResponse { get;  set; }
        
        public BaseClient(string baseUrl) 
        {
            restClient = new RestClient(baseUrl);
            restResponse = new RestResponse();
        }

        public RestRequest PostRequest(string endpoint, string payload)
        {
            var restRequest = new RestRequest(endpoint, Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest PutRequest(string endpoint, string payload)
        {
            var restRequest = new RestRequest(endpoint, Method.Put);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest GetRequest(string endpoint)
        {
            var restRequest = new RestRequest(endpoint, Method.Get);
            restRequest.AddHeader("Content-Type", "application/json");
            return restRequest;
        }
        public RestRequest DeleteRequest(string endpoint)
        {
            var restRequest = new RestRequest(endpoint, Method.Delete);
            restRequest.AddHeader("Content-Type", "application/json");
            return restRequest;
        }

        public RestResponse<T> GetResponse<T>(RestRequest request)
        {
            return restClient.Execute<T>(request);
        }
       

        //public T? GetContent<T>(RestResponse response)
        //{

        //    var content = response.Content;
        //    var dtoObject = JsonConvert.DeserializeObject<T>(content);
        //    return dtoObject;
        //}

    }
}
