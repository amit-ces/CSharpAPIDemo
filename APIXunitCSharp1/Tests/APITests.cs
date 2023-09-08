using APITestProject.Response;
using APITestProject.Requests;

namespace APITestProject.Tests
{
    public class APITests
    {
        [Fact]
        public void Test1()
        {
            var list = new UsersAPIMethods();
            var response = list.GetUsers();

            Assert.Equal(2, response.page);
            Assert.Equal("Michael1", response.data[0].first_name);

        }
    }
}