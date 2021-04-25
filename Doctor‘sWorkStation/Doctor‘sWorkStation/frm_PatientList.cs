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
    public partial class frm_PatientList : Form
    {
        private DataTable patientTable;

        public frm_PatientList()
        {
            InitializeComponent();
            this.dgvPatientList.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;        //数据网格视图的自动调整列宽模式设为显示所有单元格；

            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = $@"SELECT No,ThisNo,Name,BedNo,MainDiagnoseContent,Doctor from tb_MedicalRecord";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            this.patientTable = new DataTable();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(patientTable);
            dgvPatientList.DataSource = patientTable;
            sqlConnection.Close();
            this.dgvPatientList.Columns["No"].HeaderText = "病人ID";
            this.dgvPatientList.Columns["ThisNo"].HeaderText = "住院号";
            this.dgvPatientList.Columns["Name"].HeaderText = "名字";
            this.dgvPatientList.Columns["BedNo"].HeaderText = "床号";
            this.dgvPatientList.Columns["MainDiagnoseContent"].HeaderText = "主要诊断";
            this.dgvPatientList.Columns["Doctor"].HeaderText = "经治医生";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            DataRow[] searchResultRows =
                this.patientTable.Select($"Name LIKE '%{this.txbName.Text.Trim()}%'");					//借助本窗体的课程数据表的方法Select，并提供与SQL类似的谓词表达式作为查询条件，根据拼音缩写进行模糊查询（仅支持%通配符）；查询将返回数据行数组；
            DataTable searchResultTable = this.patientTable.Clone();                                         //借助本窗体的课程数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
            foreach (DataRow row in searchResultRows)                                                       //遍历搜索结果所在数据行数组；
            {
                searchResultTable.ImportRow(row);                                                           //数据行导入数据表；
            }
            this.dgvPatientList.DataSource = searchResultTable;
        }
    }
}
