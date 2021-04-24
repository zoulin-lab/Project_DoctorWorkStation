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
    public partial class frm_FirstAge : Form
    {
        public frm_FirstAge()
        {
            InitializeComponent();
            lblDoctor.Text = Doctor.Name;
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = " SELECT * FROM tb_MedicalRecord WHERE Doctor=@Doctor AND IsToHospital=1";//查询经治医生等于登录医生和住院状态=0的病人病历
            sqlCommand.Parameters.AddWithValue("@Doctor", Doctor.Name);//参数
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//适配器
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable PatientTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(PatientTable);
            this.lbPatient.DataSource = PatientTable;
            sqlConnection.Close();
            this.lbPatient.DisplayMember = "Name";
            this.lbPatient.ValueMember = "Name";//一定要写这一步

            
        }

        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbPatient.SelectedIndex < 0)
            {
                Patient.Name = "";
            }
            if (lbPatient.SelectedIndex >= 0)
            {
                Patient.Name = lbPatient.SelectedValue.ToString();
                //Patient.ThisNo=
            }

            frm_Information information = new frm_Information();
            information.Show();
            this.Close();
        }

        private void 移入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MoveInPatient frm_MoveInPatient = new frm_MoveInPatient(this);
            frm_MoveInPatient.Show();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NewPatient frm_NewPatient = new frm_NewPatient();
            frm_NewPatient.Show();
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 移出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbPatient.SelectedIndex < 0)
            {
                Patient.Name = "";
            }
            if (lbPatient.SelectedIndex >= 0)
            {
                Patient.Name = lbPatient.SelectedValue.ToString();
            }

            frm_MoveOutPatient frm_MoveOutPatient = new frm_MoveOutPatient(this);
            frm_MoveOutPatient.Show();
        }

        private void 病历模板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MedicalRecordTemplate frm_MedicalRecordTemplate = new frm_MedicalRecordTemplate();
            frm_MedicalRecordTemplate.Show();
        }

        private void 套餐医嘱定义ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DoctorAdviceCategory frm_DoctorAdviceCategory = new frm_DoctorAdviceCategory();
            frm_DoctorAdviceCategory.Show();
        }

        private void lbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //医嘱录入
            if (lbPatient.SelectedIndex > -1 && lbObject.SelectedIndex == 5)
            {
                frm_EnterDoctorAdvice frm_EnterDoctorAdvice = new frm_EnterDoctorAdvice();
                frm_EnterDoctorAdvice.Show();
            }
        }

        private void 药品字典ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MedicinesInquire frm_MedicinesInquire = new frm_MedicinesInquire();
            frm_MedicinesInquire.Show();
        }
    }
}
