using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Exercise.Common.Util
{
    public class GuidUtils
    {
        //本机IP地址
        private static string host_ip = null;


        /**
        * 构造函数

        */
        public GuidUtils()
        {

        }

        /**
         * 
         * 获取系统IP地址
         * 
         */
        public static void GetHostIp()
        {
            //本处获取系统的IP地址
            try
            {
                string strHostName = Dns.GetHostName(); //得到本机的主机名
                IPHostEntry ipEntry = Dns.GetHostByName(strHostName); //取得本机IP
                string strAddr = ipEntry.AddressList[0].ToString(); //假设本地主机为单网卡
                host_ip = strAddr;
            }
            catch (Exception ex)
            {
                host_ip = "";
                throw ex;
                //logger.Error("获取系统IP出错!错误信息：" + ex.Message);
            }
        }

        static GuidUtils()
        {
            GetHostIp();
        }
        /**
         * 
         * MD5算法，生成唯一ID,32位大写字符

         * 
         */
        public static string GetGuid()
        {

            StringBuilder sb = new StringBuilder(host_ip);
            sb.Append(":");

            //DateTime dt = new DateTime(1970, 1, 1);
            //TimeSpan ts = DateTime.Now - dt;
            long time = DateTime.Now.ToFileTime();
            sb.Append(time);
            sb.Append(":");
            sb.Append(new Random().Next());
            string md5 = MD5Utils.Get32MD5(sb.ToString());
            return md5.ToUpper();
        }

    }
}
