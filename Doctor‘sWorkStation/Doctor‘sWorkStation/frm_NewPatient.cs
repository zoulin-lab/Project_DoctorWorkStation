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
    public partial class frm_NewPatient : Form
    {
        public frm_NewPatient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText =$@"SELECT MR.No AS 病人ID,MR.ThisNo AS 住院号,MR.Name AS 姓名,P.Gender AS 性别,MR.BedNo AS 床号,MR.MainDiagnoseContent AS 主要诊断,MR.Doctor AS 经治医生 
                                       FROM tb_Patient AS P
                                       JOIN tb_MedicalRecord AS MR ON P.No = MR.No
                                       WHERE IsToHospital = 0
                                       ORDER BY ThisNo";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable PatientTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(PatientTable);
            this.dgvNewPatient.DataSource = PatientTable;
            sqlConnection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_FirstAge frm_FirstAge = new frm_FirstAge();
            frm_FirstAge.Show();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            string PatientID = dgvNewPatient.CurrentRow.Cells["病人ID"].Value.ToString();
            string TreatedDoctor = dgvNewPatient.CurrentRow.Cells["经治医生"].Value.ToString();
            if (TreatedDoctor == Doctor.Name||TreatedDoctor=="")
            {
                SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
                sqlConnection.ConnectionString =
                    "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
                SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
                sqlCommand.CommandText = $@"UPDATE tb_MedicalRecord SET IsToHospital=1,Doctor=@NewDoctor WHERE No=@No AND Doctor=@Doctor";
                sqlCommand.Parameters.AddWithValue("@No", PatientID);
                sqlCommand.Parameters.AddWithValue("@Doctor", TreatedDoctor);
                sqlCommand.Parameters.AddWithValue("@NewDoctor", Doctor.Name);
                sqlConnection.Open();
                int rowAffected = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("成功新建病人！");
                this.Close();
                frm_FirstAge frm_FirstAge = new frm_FirstAge();
                frm_FirstAge.Show();
            }
            else
            {
                MessageBox.Show("请选择自己负责的病人！");
            }

        }
    }
}
