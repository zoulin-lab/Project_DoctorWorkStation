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
using Microsoft.Office;
using MSWord = Microsoft.Office.Interop.Word;
using System.IO;

namespace Doctor_sWorkStation
{
    public partial class frm_MedicalRecordTemplate : Form
    {
        private DataTable TemplateTable;

        public frm_MedicalRecordTemplate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            this.dgvTemplate.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;        //数据网格视图的自动调整列宽模式设为显示所有单元格；

            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = $@"select * from tb_Template";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            this.TemplateTable = new DataTable();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(TemplateTable);
            this.dgvTemplate.DataSource = TemplateTable;
            sqlConnection.Close();
            this.dgvTemplate.Columns[this.dgvTemplate.Columns.Count-1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
        }
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string ThisFileName = this.dgvTemplate.CurrentRow.Cells["Name"].Value.ToString();
            string fileName = $@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\{ThisFileName}.docx";
            System.Diagnostics.Process.Start(fileName);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frm_EditTemplate frm_EditTemplate = new frm_EditTemplate();
            frm_EditTemplate.Show();
            this.Close();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ThisFileName = this.dgvTemplate.CurrentRow.Cells["Name"].Value.ToString();
            string fileName = $@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\{ThisFileName}.docx";
            if (File.Exists(fileName))
                File.Delete(fileName);

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand deletesqlCommand = sqlConnection.CreateCommand();
            deletesqlCommand.CommandText = $@"DELETE tb_Template WHERE No=@No";
            deletesqlCommand.Parameters.AddWithValue("@No", this.dgvTemplate.CurrentRow.Cells["No"].Value.ToString());
            sqlConnection.Open();
            int rowAffected = deletesqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show($@"{ThisFileName}删除成功！");

            if (this.dgvTemplate.RowCount == 0)                                                              //若课程数据网格视图内的行计数等于0；
                return;                                                                                     //返回；
            DataRowView currentTemolateRowView =
                this.dgvTemplate.CurrentRow.DataBoundItem as DataRowView;                                    //将课程数据网格视图的当前行的数据绑定项，转换为数据行视图；
            DataRow                                                                                         //声明数据行；
                currentTemplateRow = currentTemolateRowView.Row;													//通过当前的数据行视图，获取其相应的数据行；
                currentTemplateRow.Delete();											//从已选课程数据表的行集合中移除当前课程数据行；随后该行的状态为分离；
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
