using APIXunitCSharp1.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APIXunitCSharp1.common
{
    public static class Extensions
    {
        
        public static string GetJSONReqeustString(this IBaseClient api, string filename)
        {
            string filePath = PrepareRequestFilePath(filename);
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            return string.Empty;
        }
        
        private static string PrepareRequestFilePath(string filename)
        {
            return PrepareFilePath(Constants.usersRequestModelsFolderPath, filename);
        }
      
        static string PrepareFilePath(string basePath, string fileName)
        {
            return Path.Combine(basePath, fileName);
        }
        //public static string GetJSONResponseString(this IBaseClient api, string filename)
        //{
        //    string filePath = PrepareResponseFilePath(filename);
        //    if (File.Exists(filePath))
        //    {
        //        return File.ReadAllText(filePath);
        //    }
        //    return string.Empty;
        //}
        //private static string PrepareResponseFilePath(string filename)
        //{
        //    return PrepareFilePath(Constants.usersResponseModelsFolderPath, filename);
        //}
    }
}
