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
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = " SELECT * FROM tb_Offices";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable OfficesTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(OfficesTable);
            this.cbxOffices.DataSource = OfficesTable;
            sqlConnection.Close();
            this.cbxOffices.DisplayMember = "Name";
            this.cbxOffices.ValueMember = "OfficesNo";
            this.cbxOffices.SelectedValue = -1;//使科室下拉框为空
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (this.txbNo.Text.Trim() == "")                                                      //若用户号文本框为空；
            {
                MessageBox.Show("用户号不能为空！");														//给出错误提示；
                this.txbNo.Focus();                                                                //用户号文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.txbPassword.Text.Trim() == "")                                                    //若密码文本框为空；
            {
                MessageBox.Show("密码不能为空！");															//给出错误提示；
                this.txbPassword.Focus();                                                              //密码文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.txbName.Text.Trim() == "")                                                    //若密码文本框为空；
            {
                MessageBox.Show("姓名不能为空！");															//给出错误提示；
                this.txbName.Focus();                                                              //密码文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.cbxOffices.Text.Trim() == "")                                                    //若密码文本框为空；
            {
                MessageBox.Show("科室不能为空！");															//给出错误提示；
                this.cbxOffices.Focus();                                                              //密码文本框获得焦点；
                return;                                                                                 //返回；
            }
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                "INSERT tb_Doctor (No,Password,Name,Offices) " +
                "VALUES(@No,HASHBYTES('MD5',@Password),@Name,@Offices);";                           //指定SQL命令的命令文本；命令文本包含参数；
            sqlCommand.Parameters.AddWithValue("@No", this.txbNo.Text.Trim());                     //向SQL命令的参数集合添加参数的名称、值；
            sqlCommand.Parameters.AddWithValue("@Password", this.txbPassword.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;                           //将密码参数的类型设为变长字符串；SQL参数自动识别类型；若参数值为字符串，则类型自动设为NVARCHAR，且可在执行时自动转换；但对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
            sqlCommand.Parameters.AddWithValue("@Name", this.txbName.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Offices", this.cbxOffices.Text.Trim());
            int rowAffected = 0;                                                                        //声明整型变量，用于保存受影响行数；
            try                                                                                         //尝试；
            {
                sqlConnection.Open();                                                                   //打开SQL连接；
                rowAffected = sqlCommand.ExecuteNonQuery();                                             //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
            }
            catch (SqlException sqlEx)                                                                  //捕捉SQL异常；
            {
                if (sqlEx.Number == 2627)                                                               //若SQL异常编号为2627，则违反主键/唯一约束，即插入重复值；
                {
                    MessageBox.Show("您注册的用户号已存在，请重新输入！\n");									//给出适当的错误提示；
                }
            }
            finally                                                                                     //结束；
            {
                sqlConnection.Close();                                                                  //关闭SQL连接；
            }
            if (rowAffected == 1)                                                                       //若成功写入1行记录；
            {
                MessageBox.Show("注册成功。");															//显示正确提示；
            }
            else                                                                                        //否则；
            {
                MessageBox.Show("注册失败！");															//显示错误提示；
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.ShowDialog();
        }
    }
}
