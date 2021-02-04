using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
namespace Exercise.Common.Util
{
   public class WebUtils
    {
        public static string GetRealIP(HttpContext _httpContext)
        {
            string str = "";
            try
            {
                //HTTP_X_FORWARDED_FOR透过代理服务器获取客户端IP
                string result = _httpContext.Request.Headers["X-Forwarded-For"].FirstOrDefault();
                if (null == result || result == string.Empty)
                {
                    //如果没有代理则直接获取
                    result = _httpContext.Request.Headers["REMOTE_ADDR"].FirstOrDefault();
                }
                if (null == result || result == string.Empty)
                {
                    //还是没有获取到就用UserHostAddress获取
                    result = _httpContext.Connection.RemoteIpAddress.ToString();
                }
                str = result.Split(',')[0].Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }
    }
}
