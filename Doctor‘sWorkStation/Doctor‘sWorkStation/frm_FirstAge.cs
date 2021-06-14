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
            this.lbPatient.ValueMember = "No";//一定要写这一步

            
        }

        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbPatient.SelectedIndex < 0)
            {
                Patient.No = "";
            }
            if (lbPatient.SelectedIndex >= 0)
            {
                Patient.No = lbPatient.SelectedValue.ToString();
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
            //this.Close();
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
                Patient.No = lbPatient.SelectedValue.ToString();
                frm_EnterDoctorAdvice frm_EnterDoctorAdvice = new frm_EnterDoctorAdvice();
                frm_EnterDoctorAdvice.Show();
            }
            if (lbPatient.SelectedIndex > -1 && lbObject.SelectedIndex == 3)
            {
                if (lbPatient.SelectedIndex < 0)
                {
                    Patient.No = "";
                }
                if (lbPatient.SelectedIndex >= 0)
                {
                    Patient.No = lbPatient.SelectedValue.ToString();
                }
                frm_Information frm_Information = new frm_Information();
                frm_Information.Show();
                this.Close();
            }
            if (lbPatient.SelectedIndex > -1 && lbObject.SelectedIndex == 0)
            {
                if (System.IO.File.Exists($@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\病历\{lbPatient.Text}.docx"))
                {
                    string fileName = $@"D:\数据库作业-林立老师\Project_DoctorWorkStation\文档\病历\{lbPatient.Text}.docx";
                    System.Diagnostics.Process.Start(fileName);
                }
                else
                {
                    MessageBox.Show("该病人病历还未建立，请自行新建！");
                }
            }
        }

        private void 药品字典ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MedicinesInquire frm_MedicinesInquire = new frm_MedicinesInquire();
            frm_MedicinesInquire.Show();
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PatientList frm_PatientList = new frm_PatientList();
            frm_PatientList.Show();
        }

        private void 选择模板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TemplateConfiguration frm_TemplateConfiguration = new frm_TemplateConfiguration();
            frm_TemplateConfiguration.Show();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient.Name = lbPatient.Text.ToString();
            frm_MedicalRecordWrite frm_MedicalRecordWrite = new frm_MedicalRecordWrite();
            frm_MedicalRecordWrite.Show();
            frm_MedicalRecordWrite.Text = $"{Patient.Name}的病历";
        }

        private void 搜索病人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PatientList frm_PatientList = new frm_PatientList();
            frm_PatientList.Show();
        }

        private void 所有病人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PatientListTwo frm_PatientListTwo = new frm_PatientListTwo();
            frm_PatientListTwo.Show();
        }

        private void 等床病人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_WaitBedPatient frm_WaitBedPatient = new frm_WaitBedPatient();
            frm_WaitBedPatient.Show();
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient.No = lbPatient.SelectedValue.ToString();
            frm_CostInformation frm_CostInformation = new frm_CostInformation();
            frm_CostInformation.Show();
        }

        private void 出院通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbPatient.SelectedIndex < 0) 
            {
                Patient.No = "";
            }
            else
            {
                Patient.No = lbPatient.SelectedValue.ToString();
            }
            
            frm_DischargeNotice frm_DischargeNotice = new frm_DischargeNotice();
            frm_DischargeNotice.Show();
        }
    }
}
