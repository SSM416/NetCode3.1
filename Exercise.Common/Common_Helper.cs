using gp_DataBase.unified_users_Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise.Common
{
    public class Common_Helper
    {
        #region 验证是否符合密码格式
        /// <summary>
        /// 验证是否符合密码格式
        /// </summary>
        /// <param name="str_password">密码</param>
        /// <returns>是否符合</returns>
        public static bool IsPassword(string str_password)
        {
            Regex reg = new Regex("(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[`~!@#$%^&*()=|{}':;',\\[\\].·<>_+-/?~！@#￥……&*（）——|{}【】‘；：”“'。，、？《》])[0-9a-zA-Z`~!@#$%^&*()=|{}':;',\\[\\].·<>_+-/?~！@#￥……&*（）——|{}【】‘；：”“'。，、？《》]{10,16}");
            return reg.IsMatch(str_password);
        }
        #endregion

        #region 获取cookies
        /// <summary>
        /// 获取cookies
        /// </summary>
        /// <param name="_httpContext"></param>
        /// <returns></returns>
        public static NtUsers GetCookieValue(HttpContext _httpContext)
        {
            NtUsers user = null;
            _httpContext.Request.Cookies.TryGetValue("USER_INFO_SESSION_BACK", out string value);
            if (!string.IsNullOrWhiteSpace(value))
            {
                user = JsonConvert.DeserializeObject<NtUsers>(value);
            }
            return user;
        }
        #endregion

        #region  设置cookies
        /// <summary>
        /// 设置cookies
        /// </summary>
        /// <param name="_httpContext"></param>
        /// <param name="ntUsers"></param>
        public static void SetCookieuser(HttpContext _httpContext, NtUsers ntUsers)
        {
            NtUsers ntUsers1 = new NtUsers();

            //string value;
            //_httpContext.Request.Cookies.TryGetValue("b", out value);
            //if (value != "")
            //{
            _httpContext.Response.Cookies.Append("USER_INFO_SESSION_BACK", JsonConvert.SerializeObject(ntUsers));

            //}
        }
        #endregion
    }
}
