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

namespace Doctor_sWorkStation
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();      //声明并实例化sql连接
            sqlConnection.ConnectionString =                        //字符串变量
                "Server=(Local);" +                                 //字符串所需的服务器地址
                "Database=DataBase_DoctorWorkStation;" +            //数据库名称
                "Integrated Security=true";                         //集成安全性（即是否使用Windows验证)
            //sqlConnection.Open();                                   //打开sql连接

            SqlCommand sqlCommand = new SqlCommand();               //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                  //将SQL命令的属性Connection指向SQL连接；
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
            sqlConnection.Open();                                                                       //打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();                                             //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
            sqlConnection.Close();
            
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Name FROM tb_Doctor WHERE No= @DoctorNo";
            
            if (rowCount == 1)                                                                          //若查得所输用户号相应的1行记录；
            {
                Doctor.No = txbNo.Text;
                sqlCommand.Parameters.AddWithValue("@DoctorNo", txbNo.Text);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();//索引器
                if (sqlDataReader.Read())
                {
                    Doctor.Name = sqlDataReader["Name"].ToString();
                }
                sqlDataReader.Close();
                MessageBox.Show("登录成功。");															//显示正确提示；
                frm_FirstAge firstAge = new frm_FirstAge();
                firstAge.Show();
            }
            else                                                                                        //否则；
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");											//显示错误提示；
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
    }
}
