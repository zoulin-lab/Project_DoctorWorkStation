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
using System.IO;

namespace Doctor_sWorkStation
{
    public partial class frm_MedicalRecordWrite : Form
    {
        public frm_MedicalRecordWrite()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            txbMedicalRecordTitle.Text = Patient.Name;

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = $@"select t.No,t.Name,t.Category from tb_DoctorChooseTemplate as dct
                                        join tb_Template as t  on DCT.TemplateNo=T.No
                                        where dct.DoctorNo=@DoctorNo";
            sqlCommand.Parameters.AddWithValue("@DoctorNo", Doctor.No);
            DataTable MyTemplateTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(MyTemplateTable);
            sqlConnection.Close();
            cbxTemplate.DataSource = MyTemplateTable;
            cbxTemplate.DisplayMember = "Name";
            cbxTemplate.ValueMember = "No";
            cbxTemplate.SelectedIndex = -1;
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists($@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\病历\{this.txbMedicalRecordTitle.Text}.docx"))
            {
                string ThisFileName = this.txbMedicalRecordTitle.Text;
                string fileName = $@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\病历\{ThisFileName}.docx";
                System.Diagnostics.Process.Start(fileName);
            }
            else
            {
                MessageBox.Show("该病人病历还未建立，请自行新建！");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.cbxTemplate.SelectedIndex > 0)
            {
                if (!System.IO.File.Exists($@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\病历\{this.txbMedicalRecordTitle.Text}.docx"))
                {
                    File.Copy($@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\{this.cbxTemplate.Text}.docx", $@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\病历\{this.txbMedicalRecordTitle.Text}.docx");
                    MessageBox.Show("新建成功！");
                    string fileName = $@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\病历\{this.txbMedicalRecordTitle.Text}.docx";
                    System.Diagnostics.Process.Start(fileName);
                }
                else
                {
                    MessageBox.Show("该病人病历已存在！");
                }
            }
            else
            {
                MessageBox.Show("请选择模板！");
            }
        }
    }
}
