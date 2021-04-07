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
    public partial class frm_Information : Form
    {
        public frm_Information()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                    "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = " SELECT * FROM tb_Offices;";
            sqlCommand2.CommandText = $@"SELECT p.No AS Patient,p.Name,p.Gender,p.Career,p.Birthday,mr.InHospitalNo,MR.InHospitalCount,MR.OfficesNo 
                                         FROM tb_Patient AS P JOIN tb_MedicalRecord AS MR ON P.No = MR.No
                                         WHERE P.No = @No";
            sqlCommand2.Parameters.AddWithValue("@No", "1143868");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//适配器
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable OfficesTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(OfficesTable);
            this.cbxInHospitalRoom.DataSource = OfficesTable;
            this.cbxOutHospitalRoom.DataSource = OfficesTable;
            this.cbxInHospitalRoom.DisplayMember = "Name";
            this.cbxInHospitalRoom.ValueMember = "OfficesNo";
            this.cbxOutHospitalRoom.DisplayMember = "Name";
            this.cbxOutHospitalRoom.ValueMember = "OfficesNo";
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.txbNo.Text = sqlDataReader["Patient"].ToString();
                this.txbName.Text = sqlDataReader["Name"].ToString();
                this.rdbMale.Checked = (bool)sqlDataReader["Gender"];
                this.rdbFemale.Checked = !(bool)sqlDataReader["Gender"];
                this.txbCareer.Text = sqlDataReader["Career"].ToString();
                this.dtpBirthday.Value = (DateTime)sqlDataReader["Birthday"];
                this.txbInHospitalNo.Text = sqlDataReader["InHospitalNo"].ToString();
                this.txbInHospitalCount.Text = sqlDataReader["InHospitalCount"].ToString();
                this.cbxInHospitalRoom.SelectedValue = (int)sqlDataReader["OfficesNo"];
            }
            sqlDataReader.Close();
        }
    }
}
