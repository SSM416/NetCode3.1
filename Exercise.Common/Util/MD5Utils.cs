using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Exercise.Common.Util
{
    public class MD5Utils
    {
        public static string Get32MD5(string source)
        {
            string strResult = "";
            using MD5 md5 = MD5.Create();
            byte[] bytResult = md5.ComputeHash(Encoding.UTF8.GetBytes(source));
            for (int i = 0; i < bytResult.Length; i++)
            {
                //16进制转换 
                string temps = bytResult[i].ToString("x");
                if (temps.Length == 1)
                {
                    temps = "0" + temps;
                }
                strResult += temps;
            }
            return strResult.Substring(8, 16);
        }

        /// <summary>
        /// 对数据进行加密,生成32位的16进制字符串
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string getMD5(string strSource)
        {
            string strResult = "";
            try
            {
                //Create
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

                //注意编码UTF8、UTF7、Unicode等的选择　
                byte[] bytResult = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(strSource));

                //字节类型的数组转换为字符串

                for (int i = 0; i < bytResult.Length; i++)
                {
                    //16进制转换 
                    string temps = bytResult[i].ToString("x");
                    if (temps.Length == 1)
                    {
                        temps = "0" + temps;
                    }
                    strResult = strResult + temps;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                ///logger.Error("MD5加密算法错误!错误信息：" + ex.Message);
            }
            return strResult.Substring(8, 16);
        }
    }
}
