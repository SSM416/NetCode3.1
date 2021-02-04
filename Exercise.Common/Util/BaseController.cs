using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace Exercise.Common.Util
{
    public class BaseController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public BaseController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string read(string para)
        {
            return read(this.Request, para);
        }
        /// <summary>
        /// 读取参数数据
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public int readInt(string para)
        {
            int data = 0;
            string s = this.read(this.Request, para);
            try
            {
                data = Int32.Parse(s);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return data;
        }
        /// <summary>
        /// 读取参数数据
        /// </summary>
        /// <param name="req"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public string read(HttpRequest httpRequest, string para)
        {
            string s = httpRequest.Query[para];
            if (s == null)
            {
                try
                {
                    s = httpRequest.Cookies[para];
                }
                catch (Exception)
                {
                    s = null;
                }
            }
            if (s == null)
            {
                try
                {
                    s = httpRequest.Form[para];
                }
                catch (Exception)
                {
                    s = null;
                }
            }
            return s;
        }
        /// <summary>
        /// 根据DTO内部属性，把页面中的值赋予DTO对象
        /// </summary>
        /// <param name="dto"></param>
        public void read(Object dto)
        {
            try
            {
                //TODO
                this.copyRequest2Bean(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// 把REQUEST 对象 内容 拷贝 到对应的 BEAN 的属性 
        /// </summary>
        /// <param name="dto"></param>
        private void copyRequest2Bean(object dest)
        {
            try
            {
                Type destType = dest.GetType();
                PropertyInfo[] destPropertyInfoList = destType.GetProperties();
                try
                {
                    //循环，查找目标BEAN中的属性
                    foreach (PropertyInfo destInfo in destPropertyInfoList)
                    {
                        try
                        {
                            string key = destInfo.Name;
                            string value = this.read(key);
                            string type = destInfo.PropertyType.FullName;
                            object value2 = getValue(type, value);
                            destInfo.SetValue(dest, value2, null);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                            //logger.Error("REQUEST->BEAN,拷贝BEAN属性错误！" + ex.Message);                            
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                    //logger.Error("REQUEST->BEAN,拷贝BEAN属性错误！" + ex.Message);  
                }
            }
            catch (Exception ex)
            {
                throw ex;
                // logger.Error("REQUEST->BEAN,拷贝BEAN属性错误！" + ex.Message);  
            }
        }
        /// <summary>
        /// 根据DTO内部属性，把页面中的值赋予DTO对象
        /// </summary>
        /// <param name="dto"></param>
        public void readNew(Object dto)
        {
            try
            {
                //TODO
                this.copyRequest2BeanNew(dto);
            }
            catch (Exception ex)
            {
                throw ex;
                //logger.Error("从页面获取数据出错。错误信息是：" + e.Message);
            }

        }
        /// <summary>
        /// 把REQUEST 对象 内容 拷贝 到对应的 BEAN 的属性 
        /// </summary>
        /// <param name="dest"></param>
        private void copyRequest2BeanNew(object dest)
        {
            try
            {
                Type destType = dest.GetType();
                PropertyInfo[] destPropertyInfoList = destType.GetProperties();
                try
                {
                    //循环，查找目标BEAN中的属性


                    foreach (PropertyInfo destInfo in destPropertyInfoList)
                    {
                        try
                        {
                            string key = destInfo.Name;
                            string value = this.read(key);
                            string type = destInfo.PropertyType.FullName;
                            object value2 = getValueNew(type, value);
                            destInfo.SetValue(dest, value2, null);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                            //logger.Error("REQUEST->BEAN,拷贝BEAN属性错误！" + ex.Message);                            
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                    //logger.Error("REQUEST->BEAN,拷贝BEAN属性错误！" + ex.Message);  
                }
            }
            catch (Exception ex)
            {
                throw ex;
                // logger.Error("REQUEST->BEAN,拷贝BEAN属性错误！" + ex.Message);  
            }
        }

        #region BeanUtils
        /// <summary>
        /// 拷贝BEAN的属性 
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="source"></param>
        public static void copyBean2Bean(object dest, object source)
        {
            try
            {
                Type destType = dest.GetType();
                Type sourceType = source.GetType();

                PropertyInfo[] destPropertyInfoList = destType.GetProperties();

                PropertyInfo[] sourcePropertyInfoList = sourceType.GetProperties();

                try
                {
                    //寻找原始BEAN中的所有属性

                    foreach (PropertyInfo sourceInfo in sourcePropertyInfoList)
                    {
                        try
                        {
                            //获得原始属性的值

                            object value = sourceInfo.GetValue(source, null);

                            //循环，查找目标BEAN中的属性

                            foreach (PropertyInfo destInfo in destPropertyInfoList)
                            {
                                //找到匹配的属性值

                                if (destInfo.Name.Equals(sourceInfo.Name))
                                {
                                    //对该属性赋值                                
                                    destInfo.SetValue(dest, value, null);
                                    break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 把HASHTABLE 内容 拷贝 到对应的 BEAN 的属性 
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="source"></param>
        public static void copyHashTable2Bean(object dest, Hashtable source)
        {
            try
            {
                Type destType = dest.GetType();
                PropertyInfo[] destPropertyInfoList = destType.GetProperties();
                try
                {
                    //循环，查找目标BEAN中的属性

                    foreach (PropertyInfo destInfo in destPropertyInfoList)
                    {
                        try
                        {
                            string key = destInfo.Name;
                            object value = source[key.ToLower()];
                            if (value == null)
                            {
                                value = source[key.ToUpper()];
                            }
                            destInfo.SetValue(dest, value, null);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 根据STRING值,STRING 对象,转换成对应的对象
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object getValue(string type, string value)
        {
            try
            {

                if (type.Equals("System.String"))
                {
                    return value;
                }
                else if (type.Equals("System.Int32"))
                {
                    if (value == null || value.Length == 0)
                    {
                        value = "0";
                    }
                    return Int32.Parse(value);
                }
                else if (type.Equals("System.Single"))
                {
                    if (value == null || value.Length == 0)
                    {
                        value = "0";
                    }
                    return System.Single.Parse(value);
                }
                else if (type.Equals("System.Double"))
                {
                    if (value == null || value.Length == 0)
                    {
                        value = "0";
                    }
                    return Double.Parse(value);
                }
                else if (type.Equals("System.DateTime"))
                {
                    if (value == null || value.Trim().Length == 0 || value.CompareTo("1900") < 0)
                    {
                        return System.DateTime.Now;
                    }
                    else
                    {
                        return System.DateTime.Parse(value);
                    }
                }
                else if (type.Equals("System.Boolean"))
                {
                    if ("1".Equals(value))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return value;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据类型,转换成对应的对象
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object getValueNew(string type, string value)
        {
            try
            {
                if (type.Equals("System.String"))
                {
                    if (value != null)
                    {
                        value = value.Trim();
                    }
                    return value;
                }
                else if (type.Equals("System.Int32"))
                {
                    if (value == null || value.Length == 0)
                    {
                        value = "0";
                    }
                    return Int32.Parse(value);
                }
                else if (type.Equals("System.Single"))
                {
                    if (value == null || value.Length == 0)
                    {
                        value = "0";
                    }
                    return System.Single.Parse(value);
                }
                else if (type.Equals("System.Double"))
                {
                    if (value == null || value.Length == 0)
                    {
                        value = "0";
                    }
                    return Double.Parse(value);
                }
                else if (type.Equals("System.DateTime"))
                {
                    if (value == null || value.Trim().Length == 0 || value.CompareTo("1900") < 0)
                    {
                        return System.DateTime.Parse("1900/1/1");
                    }
                    else
                    {
                        return System.DateTime.Parse(value);
                    }
                }
                else if (type.Equals("System.Boolean"))
                {
                    if ("1".Equals(value))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return value;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        /// <summary>
        /// 保存TOKEN信息
        /// </summary>
        public void saveToken()
        {
            string token_id = GuidUtils.GetGuid();
            string md5 = MD5Utils.getMD5(token_id);
            this.ViewData["TOKEN_ID_FORM"] = new HtmlString("<input type=\"hidden\" name=\"" + "TOKEN_ID_FORM" + "\" value=\"" + md5 + "\">");
            _session.SetString("TOKEN_ID_SESSION", md5);
        }
        /// <summary>
        /// 验证FORM 内的TOKEN信息 是否与SESSION的信息一致 
        /// </summary>
        /// <returns></returns>
        public bool isValidateToken()
        {

            string md5 = _session.GetString("TOKEN_ID_SESSION");
            string md5_form = this.read("TOKEN_ID_FORM");

            if (md5.Equals(md5_form))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 生成option标签
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <param name="haveAll"></param>
        /// <returns></returns>
        public String GetOptions(string str, String key, bool haveAll)
        {

            StringBuilder sb = new StringBuilder("");

            if (haveAll)
            {
                sb.Append("<option value=\"\">请选择</option>");
            }
            if (string.IsNullOrEmpty(str))
            {
                return sb.ToString();
            }
            foreach (string i in str.Split(','))
            {
                if (i != null && key != null && i.Equals(key))
                {
                    sb.Append("<option value=\"" + i + "\"  selected=\"selected\">" + i + "</option>");
                }
                else
                {
                    sb.Append("<option value=\"" + i + "\">" + i + "</option>");
                }
            }
            return sb.ToString();
        }

    }
}
