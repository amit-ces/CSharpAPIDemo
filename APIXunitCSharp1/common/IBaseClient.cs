using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIXunitCSharp1.common
{
    public interface IBaseClient
    {

        RestRequest PostRequest(string endpoint, string payload);
        RestRequest PutRequest(string endpoint, string payload);
        RestRequest GetRequest(string endpoint);
        RestRequest DeleteRequest(string endpoint);
        RestResponse<T> GetResponse<T>(RestRequest request);
        // T? GetContent<T>(RestResponse response);
        

    }
}
