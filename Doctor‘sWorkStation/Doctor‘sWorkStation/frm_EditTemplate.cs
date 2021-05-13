using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Doctor_sWorkStation
{
    public partial class frm_EditTemplate : Form
    {
        public frm_EditTemplate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string fileName = $@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\{this.txbTemplate.Text}.docx";
            System.Diagnostics.Process.Start(fileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand insertsqlCommand = sqlConnection.CreateCommand();
            insertsqlCommand.CommandText = $@"INSERT tb_Template(Name,Category) VALUES (@Name,@Category)";
            insertsqlCommand.Parameters.AddWithValue("@Name", this.txbTemplate.Text);
            insertsqlCommand.Parameters.AddWithValue("@Category", this.txbTemplateTitle.Text);
            sqlConnection.Open();
            insertsqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            string path = @"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\";
            FileStream newTxt = File.Create(path + $"{this.txbTemplate.Text}" + ".docx");
            newTxt.Close();

            MessageBox.Show("新建成功！");

            string fileName = $@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\{this.txbTemplate.Text}.docx";
            System.Diagnostics.Process.Start(fileName);
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_EditTemplate_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_MedicalRecordTemplate frm_MedicalRecordTemplate = new frm_MedicalRecordTemplate();
            frm_MedicalRecordTemplate.Show();
        }
    }
}
