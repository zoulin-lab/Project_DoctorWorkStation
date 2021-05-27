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
    public partial class frm_NewPatientWrite : Form
    {
        public frm_NewPatientWrite()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            this.rtbDiagnose.Focus();
            this.rdbMale.Enabled = false;
            this.rdbFemale.Enabled = false;
            this.rdbMarried.Enabled = false;
            this.rdbNoMarried.Enabled = false;
            this.txbAddress.Enabled = false;
            this.txbCareer.Enabled = false;
            this.txbNation.Enabled = false;
            this.txbWorkPlace.Enabled = false;
            this.txbNo.Enabled = false;
            this.txbName.Enabled = false;
            this.dtpBirthday.Enabled = false;
            this.cbxFirstOffice.Enabled = false;

            //this.cbxInOffice.ValueMember = ;
           

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                    "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = " SELECT * FROM tb_Offices;";
            sqlCommand2.CommandText = $@"SELECT * FROM tb_Patient where No=@No";
            sqlCommand2.Parameters.AddWithValue("@No", Patient.No); //参数 
            sqlCommand3.CommandText = $@"select * from tb_Bed where Name not in(select BedNo from tb_MedicalRecord)";
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//数据适配器 
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable OfficesTable = new DataTable();//用于存放查到的表
           
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            sqlDataAdapter2.SelectCommand = sqlCommand3;
            DataTable BedTable = new DataTable();

            sqlConnection.Open();
            sqlDataAdapter.Fill(OfficesTable);
            this.cbxInOffice.DataSource = OfficesTable;
            this.cbxFirstOffice.DataSource = OfficesTable;
            this.cbxInOffice.DisplayMember = "Name";
            this.cbxInOffice.ValueMember = "OfficesNo";
            this.cbxFirstOffice.DisplayMember = "Name";
            this.cbxFirstOffice.ValueMember = "OfficesNo";
            sqlDataAdapter2.Fill(BedTable);
            this.cbxBedNo.DataSource = BedTable;
            this.cbxBedNo.DisplayMember = "Name";
            this.cbxBedNo.ValueMember = "No";
            
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();//索引器
            if (sqlDataReader.Read())
            {
                this.txbNo.Text = sqlDataReader["No"].ToString();
                this.txbName.Text = sqlDataReader["Name"].ToString();
                this.rdbMarried.Checked = (bool)sqlDataReader["IsMarried"];
                    this.rdbNoMarried.Checked = !(bool)sqlDataReader["IsMarried"];
                if (sqlDataReader["Gender"].ToString() == "男")
                {
                    this.rdbMale.Checked = true;
                    this.rdbFemale.Checked = false;
                }
                else
                {
                    this.rdbMale.Checked = false;
                    this.rdbFemale.Checked = true;
                }
                
                this.txbCareer.Text = sqlDataReader["Career"].ToString();
                this.dtpBirthday.Value = (DateTime)sqlDataReader["Birthday"];
                this.txbAddress.Text = sqlDataReader["Address"].ToString();
                this.txbNation.Text = sqlDataReader["Nation"].ToString();
                this.cbxFirstOffice.SelectedValue = sqlDataReader["OfficeNo"];
                this.txbWorkPlace.Text = sqlDataReader["WorkPlace"].ToString();
                this.cbxInOffice.SelectedValue = -1;
                this.cbxInOffice.SelectedValue = sqlDataReader["OfficeNo"];
                this.cbxBedNo.SelectedValue = -1;
                sqlConnection.Close();

            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.cbxInOffice.SelectedIndex >= 0 && this.rtbDiagnose.Text != "" && this.txbThisNo.Text != "") 
            {
                SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
                sqlConnection.ConnectionString =
                        "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
                SqlCommand insertCommand = sqlConnection.CreateCommand();
                insertCommand.CommandText = $@"insert tb_MedicalRecord(No,Name,ThisNo,InHospitalCount,OfficesNo,BedNo,InDate,MainDiagnoseContent,Doctor,IsToHospital,OutOfficesNo)
                                           values(@No,@Name,@ThisNo,1,@OfficesNo,@BedNo,@InDate,@MainDiagnoseContent,@Doctor,@IsToHospital,0)";
                insertCommand.Parameters.AddWithValue("@No", this.txbNo.Text);
                insertCommand.Parameters.AddWithValue("@Name", this.txbName.Text);
                insertCommand.Parameters.AddWithValue("@ThisNo", this.txbThisNo.Text);
                insertCommand.Parameters.AddWithValue("@OfficesNo", this.cbxInOffice.SelectedValue);
                insertCommand.Parameters.AddWithValue("@BedNo", this.cbxBedNo.Text);
                insertCommand.Parameters.AddWithValue("@InDate", this.dtpInDate.Value);
                insertCommand.Parameters.AddWithValue("@MainDiagnoseContent", this.rtbDiagnose.Text);
                insertCommand.Parameters.AddWithValue("@Doctor", Doctor.Name);
                insertCommand.Parameters.AddWithValue("@IsToHospital", 0);
                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (this.cbxBedNo.Text == "")
                {
                    MessageBox.Show($"暂无空闲病床！病人{this.txbName.Text}成为等床病人！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"病人{this.txbName.Text}新建成功！");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("请输入入院诊断或住院号！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NewPatientWrite_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_NewPatient frm_NewPatient = new frm_NewPatient();
            frm_NewPatient.Show();
        }
    }
}
