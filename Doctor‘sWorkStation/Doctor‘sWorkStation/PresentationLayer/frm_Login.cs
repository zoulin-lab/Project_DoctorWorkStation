using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Doctor_sWorkStation.BusinessLogicLayer;

namespace Doctor_sWorkStation
{
    public partial class frm_Login : Form
    {
        /// <summary>
		/// 用户；
		/// </summary>
		private Doctor Doctor { get; set; }
        /// <summary>
        /// 用户（业务逻辑层）；
        /// </summary>
        private IDoctorBll DoctorBll { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// 

        Doctor doctor = new Doctor();

        public frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；

            this.txbNo.Validating += ValidateNo;
            this.txbPassword.Validating += ValidatePassword;
            this.ErrorProvider.BlinkRate = 500;
           

        }

        private void ValidatePassword(object sender, CancelEventArgs e)
        {
            string password = this.txbPassword.Text;
            bool isEmpty = string.IsNullOrEmpty(password);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txbPassword, "密码不能为空");
                return;
            }
            this.ErrorProvider.SetError(this.txbPassword, "");
        }


        //后加用来辅助验证
        public bool CheckExist(string doctorNo)
       => this.SelectCount(doctorNo) == 1;
        //后加用来辅助验证
        public int SelectCount(string doctorNo)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandText = "SELECT COUNT(1) FROM tb_Doctor WHERE No=@No;";
            sqlCommand1.Parameters.AddWithValue("@No", doctorNo);
            sqlConnection.Open();
            int count = (int)sqlCommand1.ExecuteScalar();
            sqlConnection.Close();
            return count;
        }
        //验证用户号是否存在及用户号长度是否正确
        private void ValidateNo(object sender, CancelEventArgs e)
        {
            string doctorNo = this.txbNo.Text;
            bool isEmpty = string.IsNullOrEmpty(doctorNo);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txbNo, "用户号不能为空");
                return;
            }
            bool isLengthValid =
                doctorNo.Length >= 4  /*this.DoctorBll.DoctorNoMinLength*/
                && doctorNo.Length <= 7; /*this.DoctorBll.DoctorNoMaxLength;*/
            if (!isLengthValid)
            {
                this.ErrorProvider.SetError
                    (this.txbNo,
                    $"用户号长度应为{4/*this.DoctorBll.DoctorNoMinLength*/}~{7/*this.DoctorBll.DoctorNoMaxLength*/}");
                return;
            }
            bool isExisting = this/*.DoctorBll.*/.CheckExist(doctorNo);
            if (!isExisting)
            {
                this.ErrorProvider.SetError(this.txbNo, "用户号不存在");
                return;
            }
            this.ErrorProvider.SetError(this.txbNo, "");
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();      //声明并实例化sql连接
            sqlConnection.ConnectionString =                        //字符串变量
                "Server=(Local);" +                                 //字符串所需的服务器地址
                "Database=DataBase_DoctorWorkStation;" +            //数据库名称
                "Integrated Security=true;MultipleActiveResultSets=true ";                       //集成安全性（即是否使用Windows验证)
            //MultipleActiveResultSets=true
            //目的是将数据库连接设置可复用，即可供多个SqlCommand同时使用
            SqlCommand sqlCommand = new SqlCommand();             
            sqlCommand.Connection = sqlConnection;                  
            sqlCommand.CommandText =
                "SELECT COUNT(1) FROM tb_Doctor WHERE No=@No AND Password=HASHBYTES('MD5',@Password);";   //指定SQL命令的命令文本；命令文本包含参数； 
            #region SQL参数用法1
            SqlParameter sqlParameter = new SqlParameter();                                             //声明并实例化SQL参数；
            sqlParameter.ParameterName = "@No";                                                         //设置SQL参数的名称；
            sqlParameter.Value = this.txbNo.Text.Trim();                                           //设置SQL参数的长度；
            sqlParameter.SqlDbType = SqlDbType.Char;                                                    //设置SQL参数对应的SQL Server数据类型；
            sqlParameter.Size = 6;                                                                     //设置SQL参数的长度；
            sqlCommand.Parameters.Add(sqlParameter);                                                    //向SQL命令的参数集合添加SQL参数；
            #endregion
            #region SQL参数用法2
            sqlCommand.Parameters.AddWithValue("@Password", this.txbPassword.Text.Trim());             //直接调用方法AddWithValue向SQL命令的参数集合添加参数的名称、值；SQL参数能自动识别类型，但若SQL参数被用作某函数的输入参数，则使用函数定义的参数类型作为SQL参数类型；
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;                           //通过参数名称访问SQL参数，并将密码参数的类型设为变长字符串；由于HASHBYTES函数的参数为NVARCHAR，则SQL参数类型自动设为NVARCHAR；对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
            #endregion

            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand2.CommandText = "SELECT * FROM tb_Doctor WHERE No= @DoctorNo";
            sqlCommand2.Parameters.AddWithValue("DoctorNo", this.txbNo.Text.Trim());
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();//查询输入用户是否被冻结
            int rowCount = (int)sqlCommand.ExecuteScalar();//验证密码是否正确
            //Doctor doctor = null;
            if (sqlDataReader.Read())//赋给doctor是否被冻结的值，用于判断
            {
                Doctor.No = sqlDataReader["No"].ToString();
                doctor.IsActivated = (bool)sqlDataReader["IsActivated"];
                doctor.LoginFailCount = (int)sqlDataReader["LoginFailCount"];
            }
            sqlConnection.Close();

            if (doctor.IsActivated == false) //验证输入用户是否被冻结
            {
                MessageBox.Show("您的账号已被冻结！需要重新验证！");
                return;
            }
            if (rowCount == 1)                                                                           //若查得所输用户号相应的1行记录；
            {
                Doctor.No = txbNo.Text;
                sqlConnection.Open();
                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();//索引器
                if (sqlDataReader2.Read())
                {
                    Doctor.Name = sqlDataReader2["Name"].ToString();
                    Doctor.OfficeNo= sqlDataReader2["OfficeNo"].ToString();
                }
                 sqlConnection.Close();
                MessageBox.Show("登录成功。");
                doctor.LoginFailCount = 0;
                //this.Update();

                SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
                sqlCommand3.CommandText = $@"UPDATE tb_Doctor SET
                                           IsActivated = @IsActivated
                                          , LoginFailCount = @LoginFailCount WHERE No = @No";
                sqlCommand3.Parameters.AddWithValue("@No", Doctor.No);
                sqlCommand3.Parameters.AddWithValue("@IsActivated", doctor.IsActivated);
                sqlCommand3.Parameters.AddWithValue("@LoginFailCount", doctor.LoginFailCount);
                sqlConnection.Open();
                int x = sqlCommand3.ExecuteNonQuery();
                sqlConnection.Close();
                
                frm_FirstAge firstAge = new frm_FirstAge();
                firstAge.Show();
            }
            else                                                                                        //否则；
            {
                doctor.LoginFailCount++;
                string errorMessage =
                    doctor.IsActivated ?
                    $"密码错误，请重新输入！\n您还有{3 - doctor.LoginFailCount}次机会！"
                    : $"密码错误已达{3}次上限！";
                MessageBox.Show(errorMessage);                                          //显示错误提示；
                this.UpdateInfo();//更新错误次数及冻结用户
                this.txbPassword.Focus();                                                              //密码文本框获得焦点；
                this.txbPassword.SelectAll();                                                          //密码文本框内所有文本被选中；
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            frm_SignUp signUp = new frm_SignUp();
            signUp.Show();
            this.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
		/// 处理用户登录失败次数过多；
		/// </summary>
		/// <param name="doctor">用户</param>
		private void UpdateInfo()
        {
            if (doctor.LoginFailCount >= 3)
            {
                doctor.IsActivated = false;
            }
            SqlConnection sqlConnection = new SqlConnection();                                      
                sqlConnection.ConnectionString =
                    "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"UPDATE tb_Doctor SET
                                           IsActivated = @IsActivated
                                          , LoginFailCount = @LoginFailCount WHERE No = @No";
            sqlCommand.Parameters.AddWithValue("@No", Doctor.No);
            sqlCommand.Parameters.AddWithValue("@IsActivated", doctor.IsActivated);
            sqlCommand.Parameters.AddWithValue("@LoginFailCount", doctor.LoginFailCount);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}
