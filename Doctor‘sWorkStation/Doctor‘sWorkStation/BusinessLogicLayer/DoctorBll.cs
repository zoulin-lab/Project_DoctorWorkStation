using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Doctor_sWorkStation.DataAccessLayer;

namespace Doctor_sWorkStation.BusinessLogicLayer
{
    public class DoctorBll : IDoctorBll
    {
        /// <summary>
		/// 用户（数据访问层）；
		/// </summary>
		private IDoctorDal DoctorDal { get; set; }
        /// <summary>
        /// 登录失败次数上限；
        /// </summary>
        private int LogInFailCountMax => 3;
        /// <summary>
        /// 用户号最小长度；
        /// </summary>
        public int DoctorNoMinLength => 3;
        /// <summary>
        /// 用户号最大长度；
        /// </summary>
        public int DoctorNoMaxLength => 10;
        /// <summary>
        /// 是否完成登录；
        /// </summary>
        public bool HasLoggedIn { get; private set; }
        /// <summary>
        /// 是否完成注册；
        /// </summary>
        public bool HasSignedUp { get; private set; }
        /// <summary>
        /// 消息；
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
        /// MD5加密；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        private byte[] Md5(string plainText)
        {
            byte[] plainBytes = Encoding.Default.GetBytes(plainText);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] cryptedBytes = md5.ComputeHash(plainBytes);
            return cryptedBytes;
        }
        /// <summary>
        /// MD5值是否相等；
        /// </summary>
        /// <param name="md5">MD5值</param>
        /// <param name="otherPlainText">另一明文</param>
        /// <returns>是否相等</returns>
        private bool Md5Equal(byte[] md5, string otherPlainText)
        => md5.SequenceEqual(this.Md5(otherPlainText));
        /// <summary>
        /// 处理用户不存在；
        /// </summary>
        /// <param name="user">用户</param>
        private void HandleUserNotExist(Doctor doctor)
        {
            if (doctor == null)
            {
                string errorMessage = "用户号不存在！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理用户被冻结；
        /// </summary>
        /// <param name="user">用户</param>
        private void HandleUserNotActivated(Doctor doctor)
        {
            if (!doctor.IsActivated)
            {
                string errorMessage = "用户已被冻结，需要手机验证！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理用户登录失败次数过多；
        /// </summary>
        /// <param name="user">用户</param>
        private void HandleUserLoginFailTooManyTimes(Doctor doctor)
        {
            if (doctor.LoginFailCount >= this.LogInFailCountMax)
            {
                doctor.IsActivated = false;
                this.DoctorDal.Update(doctor);
            }
        }
        /// <summary>
        /// 处理用户登录失败；
        /// </summary>
        /// <param name="user">用户</param>
        private void HandleUserLoginFail(Doctor doctor)
        {
            doctor.LoginFailCount++;
            this.DoctorDal.Update(doctor);
        }
        /// <summary>
        /// 处理用户密码错误；
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="password">密码</param>
        private void HandleUserPasswordNotMatch(Doctor doctor, string password)
        {
            bool isPasswordMatch = this.Md5Equal(doctor.Password, password);
            if (!isPasswordMatch)
            {
                this.HandleUserLoginFail(doctor);
                this.HandleUserLoginFailTooManyTimes(doctor);
                string errorMessage =
                    doctor.IsActivated ?
                    $"密码错误，请重新输入！\n您还有{this.LogInFailCountMax - doctor.LoginFailCount}次机会！"
                    : $"密码错误已达{this.LogInFailCountMax}次上限！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理用户登录成功；
        /// </summary>
        /// <param name="user">用户</param>
        private void HandleUserLoginOk(Doctor doctor)
        {
            if (doctor.LoginFailCount != 0)
            {
                doctor.LoginFailCount = 0;
                this.DoctorDal.Update(doctor);
            }
            this.HasLoggedIn = true;
            this.Message = "登录成功。";
        }
        /// <summary>
        /// 检查是否存在；
        /// </summary>
        /// <param name="userNo">用户号</param>
        /// <returns>是否存在</returns>
        public bool CheckExist(string doctorNo)
        => this.DoctorDal.SelectCount(doctorNo) == 1;
        /// <summary>
        /// 检查是否不存在；
        /// </summary>
        /// <param name="doctorNo">用户号</param>
        /// <returns>是否不存在</returns>
        public bool CheckNotExist(string doctorNo)
        => !this.CheckExist(doctorNo);
        /// <summary>
        /// 登录；
        /// </summary>
        /// <param name="userNo">用户号</param>
        /// <param name="password">密码</param>
        /// <returns>用户</returns>
        public Doctor LogIn(string doctorNo, string password)
        {
            this.HasLoggedIn = false;
            Doctor doctor = this.DoctorDal.Select(doctorNo);
            try
            {
                this.HandleUserNotExist(doctor);
                this.HandleUserNotActivated(doctor);
                this.HandleUserPasswordNotMatch(doctor, password);
                this.HandleUserLoginOk(doctor);
            }
            catch (ApplicationException ex)
            {
                this.Message = ex.Message;
            }
            catch (Exception)
            {
                this.Message = "登录失败！";
            }
            return doctor;
        }
        /// <summary>
        /// 注册；
        /// </summary>
        /// <param name="userNo">用户号</param>
        /// <param name="password">密码</param>
        /// <returns>用户</returns>
        public Doctor SignUp(string doctorNo, string password)
        {
            this.HasSignedUp = false;
            Doctor doctor = new Doctor()
            {
                No2 = doctorNo,
                Password = Md5(password),
                IsActivated = true
            };
            try
            {
                this.DoctorDal.Insert(doctor);
                this.HasSignedUp = true;
                this.Message = "注册成功。";
            }
            catch (ApplicationException ex)
            {
                this.Message = $"{ex.Message}\n注册失败！";
            }
            catch (Exception)
            {
                this.Message = "注册失败！";
            }
            return doctor;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        public DoctorBll()
        {
            this.DoctorDal = new DoctorDal();
        }
    }
}
