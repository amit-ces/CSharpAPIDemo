using APITestProject.Response;
using APITestProject.Requests;
using APITestProject.common;
using System.Net;
using System.Xml.Linq;
using APIXunitCSharp1.Requests;
using APIXunitCSharp1.Models.Request;
using APIXunitCSharp1.common;

namespace APITestProject.Tests
{
    public class APITests
    {
        string baseUrl = Constants.APIBaseURL;

        IUsersAPIMethods usersApi { set; get; }
        public APITests()
        {
            usersApi = new UsersAPIMethods(baseUrl);
        }
        [Theory]
        [InlineData("/api/users")]
        public void UsersList(string apiUrl)
        {
            //var apiMethods = new UsersAPIMethods<AllUsersResponse>(baseUrl);
            var response = usersApi.GetUsers(apiUrl);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var dataResponse = response.Data;
                if(dataResponse != null) {
                    Assert.Equal(6, dataResponse.per_page);
                    Assert.Equal(1, dataResponse.page);
                    Assert.Equal("George", dataResponse.data[0].first_name);
                    Assert.Equal("Janet", dataResponse.data[1].first_name);
                }
                
            }
            

        }

        [Theory]
        [InlineData("/api/users", "CreateUser.json")]
        public void AddUser(string apiUrl, string requestFileName)
        {
            //CreateUser userPayLoad = new CreateUser() { name = "Amit", job = "QA" };
            //var response = usersApi.CreateUsers(apiUrl, (string)userPayLoad);
            string jsonRequest = ((IBaseClient)usersApi).GetJSONReqeustString(requestFileName);
           
            var response = usersApi.CreateUsers(apiUrl, jsonRequest);
            var responseData = response.Data;
            if(responseData != null)
            {
                Assert.Equal("Amit", responseData.name, ignoreCase: true);
                Assert.Equal("QA", responseData.job, ignoreCase: true);
            }

        }

    }
}