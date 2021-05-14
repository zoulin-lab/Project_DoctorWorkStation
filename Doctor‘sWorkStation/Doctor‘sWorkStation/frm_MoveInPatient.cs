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
    public partial class frm_MoveInPatient : Form
    {
        Form PatientForm = null;
        public frm_MoveInPatient(Form form)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            this.dgvMoveInPatient.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;                                                   //数据网格视图的自动调整列宽模式设为显示所有单元格；

            PatientForm = form;
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = $@"SELECT MR.No AS 病人ID ,P.Gender AS 性别 ,MR.Name AS 名字,MR.ThisNo AS 住院号 FROM tb_MedicalRecord AS MR
		                                JOIN tb_Patient AS P ON MR.No=P.No
		                                WHERE (Doctor=@No AND IsToHospital!=1 And BedNo!='') OR (Doctor='' AND IsToHospital!=1 And BedNo!='') ";
            sqlCommand.Parameters.AddWithValue("@No", Doctor.Name);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable PatientTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(PatientTable);
            this.dgvMoveInPatient.DataSource = PatientTable;
            sqlConnection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            string No = dgvMoveInPatient.CurrentRow.Cells["病人ID"].Value.ToString();
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "UPDATE tb_MedicalRecord SET IsToHospital=1,Category=@Category,Doctor=@Doctor WHERE No=@No";
            sqlCommand.Parameters.AddWithValue("@Category", rbnInHospital.Checked);
            sqlCommand.Parameters.AddWithValue("@Doctor", Doctor.Name);
            sqlCommand.Parameters.AddWithValue("@No", No);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("成功移入病人！");
            PatientForm.Close();
            this.Close();
        }

        private void frm_MoveInPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_FirstAge frm_FirstAge = new frm_FirstAge();
            frm_FirstAge.Show();
        }
    }
}
