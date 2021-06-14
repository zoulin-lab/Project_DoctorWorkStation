using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_sWorkStation
{
    public class Doctor//用于储存登录后的医生姓名和账号
    {
        public static string No;
        public static string Name;
        public static string OfficeNo;

        /// <summary>
        /// 用户号；
        /// </summary>
        public string No2
        {
            get;
            set;
        }
        /// <summary>
        /// 密码（加密）；
        /// </summary>
        public byte[] Password
        {
            get;
            set;
        }
        /// <summary>
        /// 是否激活；
        /// </summary>
        public bool IsActivated
        {
            get;
            set;
        }
        /// <summary>
        /// 登录错误次数；
        /// </summary>
        public int LoginFailCount
        {
            get;
            set;
        }
    }
}
