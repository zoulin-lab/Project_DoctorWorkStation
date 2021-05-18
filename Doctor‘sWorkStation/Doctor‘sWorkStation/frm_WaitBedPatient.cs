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
    public partial class frm_WaitBedPatient : Form
    {
        public frm_WaitBedPatient()
        {
            InitializeComponent();
            this.dgvWaitBedPatient.BackgroundColor = Color.White;
            this.dgvWaitBedPatient.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvWaitBedPatient.RowHeadersVisible = false;

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = new SqlCommand();                                                   //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                                      //将SQL命令的连接属性指向SQL连接；
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
            sqlCommand.CommandText =                                                                    //指定SQL命令的命令文本；
                "select No,Name,ThisNo,BedNo,MainDiagnoseContent from tb_MedicalRecord where BedNo='' and Doctor=@Doctor";
            sqlCommand.Parameters.AddWithValue("@Doctor", Doctor.Name);
            sqlCommand2.CommandText = "select COUNT(1) from tb_Bed " +
                "where Name not in(select BedNo from tb_MedicalRecord)";
            sqlCommand3.CommandText = "select No,Name from tb_Bed where Name not in(select BedNo from tb_MedicalRecord) ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();                                       //声明并实例化SQL数据适配器，同时借助构造函数，将其SelectCommand属性设为先前创建的SQL命令；
            sqlDataAdapter.SelectCommand = sqlCommand;                                                  //将SQL数据适配器的查询命令属性指向SQL命令；
            DataTable PatientTable = new DataTable();
            DataTable BedTable = new DataTable();

            DataGridViewComboBoxColumn dgvcbxc = new DataGridViewComboBoxColumn();

            sqlConnection.Open();                                                                       //打开SQL连接；
            sqlDataAdapter.Fill(PatientTable);
            sqlDataAdapter.SelectCommand = sqlCommand3;
            sqlDataAdapter.Fill(BedTable);
            int ReadBedCount = Convert.ToInt32(sqlCommand2.ExecuteScalar());                                                             //SQL数据适配器读取数据，并填充数据集；
            sqlConnection.Close();

            this.dgvWaitBedPatient.Columns.Clear();
            this.dgvWaitBedPatient.DataSource = PatientTable;
            this.dgvWaitBedPatient.Columns["No"].HeaderText = "病人ID";
                this.dgvWaitBedPatient.Columns["Name"].HeaderText = "姓名";
            this.dgvWaitBedPatient.Columns["ThisNo"].HeaderText = "住院号";
            this.dgvWaitBedPatient.Columns["MainDiagnoseContent"].HeaderText = "入院诊断";
            this.dgvWaitBedPatient.Columns["BedNo"].Visible=false;
            dgvcbxc.DataSource = BedTable;
            dgvcbxc.Name = "Bed";
            dgvcbxc.HeaderText = "选择床号";
            dgvcbxc.DisplayMember = "Name";
            dgvcbxc.ValueMember = "Name";
            dgvcbxc.DataPropertyName = "BedNo";//与数据库数据源绑定
            this.dgvWaitBedPatient.Columns.Add(dgvcbxc);
            dgvcbxc.DisplayIndex = 3;
            this.dgvWaitBedPatient.Columns[this.dgvWaitBedPatient.Columns.Count - 2].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;

            lblBed.Text = $"剩余{ReadBedCount}个空闲床位！";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand updateCommand = sqlConnection.CreateCommand();
            updateCommand.CommandText = "update tb_MedicalRecord set BedNo=@BedNo where No=@No";
            if (this.dgvWaitBedPatient.CurrentRow.Cells["Bed"].Value.ToString() != "")
            {
                updateCommand.Parameters.AddWithValue("@BedNo", this.dgvWaitBedPatient.CurrentRow.Cells["Bed"].Value.ToString());
                updateCommand.Parameters.AddWithValue("@No", this.dgvWaitBedPatient.CurrentRow.Cells["No"].Value.ToString());
                sqlConnection.Open();
                updateCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("等床成功！");
            }
            else
            {
                MessageBox.Show("暂无空闲病床！");
            }
        }
    }
}
