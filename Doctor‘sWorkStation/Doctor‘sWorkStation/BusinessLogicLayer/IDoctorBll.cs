using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_sWorkStation.BusinessLogicLayer
{
    public interface IDoctorBll
    {
        /// <summary>
		/// 用户号最小长度；
		/// </summary>
		int DoctorNoMinLength { get; }
        /// <summary>
        /// 用户号最大长度；
        /// </summary>
        int DoctorNoMaxLength { get; }
        /// <summary>
        /// 是否完成登录；
        /// </summary>
        bool HasLoggedIn { get; }
        /// <summary>
        /// 是否完成注册；
        /// </summary>
        bool HasSignedUp { get; }
        /// <summary>
        /// 消息；
        /// </summary>
        string Message { get; }
        /// <summary>
        /// 检查是否存在；
        /// </summary>
        /// <param name="userNo">用户号</param>
        /// <returns>是否存在</returns>
        bool CheckExist(string userNo);
        /// <summary>
        /// 检查是否不存在；
        /// </summary>
        /// <param name="doctorNo">用户号</param>
        /// <returns>是否不存在</returns>
        bool CheckNotExist(string doctorNo);
        /// <summary>
        /// 登录；
        /// </summary>
        /// <param name="doctorNo">用户号</param>
        /// <param name="password">密码</param>
        /// <returns>用户</returns>
        Doctor LogIn(string doctorNo, string password);
        /// <summary>
        /// 注册；
        /// </summary>
        /// <param name="doctorNo">用户号</param>
        /// <param name="password">密码</param>
        /// <returns>用户</returns>
        Doctor SignUp(string doctorNo, string password);
    }
}
