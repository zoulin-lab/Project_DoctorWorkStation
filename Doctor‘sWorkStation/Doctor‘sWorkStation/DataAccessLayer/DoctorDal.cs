using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Doctor_sWorkStation.DataAccessLayer
{
    public class DoctorDal:IDoctorDal
    {
        /// <summary>
		/// 查询用户计数;
		/// </summary>
		/// <param name="userNo">用户号</param>
		/// <returns>计数</returns>
		public int SelectCount(string doctorNo)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString =
            //    ConfigurationManager.ConnectionStrings["Sql"].ToString();
            //SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            //sqlCommand1.CommandText = "usp_selectUserCount"; 
            //sqlCommand1.CommandType = CommandType.StoredProcedure;

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandText = "SELECT COUNT(1) FROM tb_User AS U WHERE U.No = @No; ";
            sqlCommand1.Parameters.AddWithValue("@No", doctorNo);
            sqlConnection.Open();
            int count = (int)sqlCommand1.ExecuteScalar();
            sqlConnection.Close();
            return count;
        }
        /// <summary>
        /// 查询用户；
        /// </summary>
        /// <param name="userNo">用户号</param>
        /// <returns>用户</returns>
        public Doctor Select(string doctorNo)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString =
            //    ConfigurationManager.ConnectionStrings["Sql"].ToString();
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "usp_selectUser";
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT U.Password ,U.IsActivated ,U.LoginFailCoun  FROM
                                        tb_User AS U WHERE U.No = @No; ";
            sqlCommand.Parameters.AddWithValue("@No", doctorNo);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Doctor doctor = null;
            if (sqlDataReader.Read())
            {
                doctor = new Doctor()
                {
                    No2 = doctorNo,
                    Password = (byte[])sqlDataReader["Password"],
                    IsActivated = (bool)sqlDataReader["IsActivated"],
                    LoginFailCount = (int)sqlDataReader["LoginFailCount"]
                };
            }
            sqlDataReader.Close();
            return doctor;
        }
        /// <summary>
        /// 更新用户；
        /// </summary>
        /// <param name="doctor">用户</param>
        /// <returns>受影响行数</returns>
        public int Update(Doctor doctor)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString =
            //    ConfigurationManager.ConnectionStrings["Sql"].ToString();
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "usp_updateUser";
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                $@"UPDATE tb_User SET
                   Password = @Password
                  ,IsActivated = @IsActivated
                  ,LoginFailCount = @LoginFailCount
                   WHERE No = @No; ";
            sqlCommand.Parameters.AddWithValue("@No", doctor.No2);
            sqlCommand.Parameters.AddWithValue("@Password", doctor.Password);
            sqlCommand.Parameters.AddWithValue("@IsActivated", doctor.IsActivated);
            sqlCommand.Parameters.AddWithValue("@LoginFailCount", doctor.LoginFailCount);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected;
            
        }
        /// <summary>
        /// 插入用户；
        /// </summary>
        /// <param name="doctor">用户</param>
        /// <returns>受影响行数</returns>
        public int Insert(Doctor doctor)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString =
            //    ConfigurationManager.ConnectionStrings["Sql"].ToString();
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "usp_insertUser";
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                "INSERT tb_Doctor (No,Password,Name,Offices,IsActivated) " +
                "VALUES(@No,HASHBYTES('MD5',@Password),@Name,@Offices,@IsActivated);";
            sqlCommand.Parameters.AddWithValue("@No", doctor.No2);
            sqlCommand.Parameters.AddWithValue("@Password", doctor.Password);
            sqlCommand.Parameters.AddWithValue("@IsActivated", doctor.IsActivated);
            int rowAffected = 0;
            try
            {
                sqlConnection.Open();
                rowAffected = sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    throw new ApplicationException("您提交的用户号已存在");
                }
                throw sqlEx;
            }
            finally
            {
                sqlConnection.Close();
            }
            return rowAffected;
        }
    }
}
