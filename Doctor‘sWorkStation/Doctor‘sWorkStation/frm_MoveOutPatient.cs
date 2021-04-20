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
    public partial class frm_MoveOutPatient : Form
    {
        Form Patientform = null;
        public frm_MoveOutPatient(Form form)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            txbNo.Text = Doctor.No;
            Patientform = form;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                "SELECT COUNT(1) FROM tb_Doctor WHERE No=@No AND Password=HASHBYTES('MD5',@Password);";                           //指定SQL命令的命令文本；命令文本包含参数；
            sqlCommand.Parameters.AddWithValue("@No", this.txbNo.Text.Trim());                     //向SQL命令的参数集合添加参数的名称、值；
            sqlCommand.Parameters.AddWithValue("@Password", this.txbPassword.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlConnection.Open();                                                                       //打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();                                             //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
            sqlConnection.Close();

            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand2.CommandText = "UPDATE tb_MedicalRecord SET Doctor='',IsToHospital = 0 WHERE Doctor=@Doctor AND Name=@Name";
            sqlCommand2.Parameters.AddWithValue("@Doctor", Doctor.Name);
            sqlCommand2.Parameters.AddWithValue("@Name", Patient.Name);
            if (rowCount == 1 && txbNo.Text == Doctor.No)                                                                         //若查得所输用户号相应的1行记录；
            {
                sqlConnection.Open();
                sqlCommand2.ExecuteNonQuery();//执行并返回结果
                sqlConnection.Close();
                MessageBox.Show($"移出成功！");
                Patientform.Close();//关闭父窗体
                this.Close();
            }
            else                                                                                        //否则；
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");											//显示错误提示；
                this.txbPassword.Focus();                                                              //密码文本框获得焦点；
                this.txbPassword.SelectAll();                                                          //密码文本框内所有文本被选中；
            }
        }

        private void frm_MoveOutPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_FirstAge frm_FirstAge = new frm_FirstAge();
            frm_FirstAge.Show();
        }
        
    }
}
