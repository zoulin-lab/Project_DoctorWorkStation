using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_sWorkStation.DataAccessLayer
{
    public interface IDoctorDal
    {
        /// <summary>
		/// 插入用户；
		/// </summary>
		/// <param name="doctor">用户</param>
		/// <returns>受影响行数</returns>
		int Insert(Doctor doctor);
        /// <summary>
        /// 查询用户；
        /// </summary>
        /// <param name="doctorNo">用户号</param>
        /// <returns>用户</returns>
        Doctor Select(string doctorNo);
        /// <summary>
        /// 查询用户计数
        /// </summary>
        /// <param name="doctorNo"></param>
        /// <returns></returns>
        int SelectCount(string doctorNo);
        /// <summary>
        /// 更新用户；
        /// </summary>
        /// <param name="user">用户</param>
        /// <returns>受影响行数</returns>
        int Update(Doctor doctor);
    }
}
