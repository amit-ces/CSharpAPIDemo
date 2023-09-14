using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace APIXunitCSharp1.common
{
    public static class Constants
    {
        public static string usersRequestModelsFolderPath = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)) + @"\..\..\..\Models\Requests\";
        public static string usersResponseModelsFolderPath = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)) + @"\..\..\..\Models\Responses\";

        public static string APIBaseURL = "https://reqres.in";
    }
}
