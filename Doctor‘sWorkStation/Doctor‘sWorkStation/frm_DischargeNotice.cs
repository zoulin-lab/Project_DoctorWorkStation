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
    public partial class frm_DischargeNotice : Form
    {
        public frm_DischargeNotice()
        {
            InitializeComponent();
            this.dgvInfo.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInfo.RowHeadersVisible = false;
            this.dgvInfo2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInfo2.RowHeadersVisible = false;

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select p.Name,pda.LongOrShort,dac.Name as CategoryName,pda.Content,pda.HowMuch,pda.Nnit,pda.Way,pda.Frequency,
                                        pda.StopDateTime,pl.Price from tb_PatientDoctorAdvice as pda 
                                        join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        join tb_PatientPriceList as pl on pl.AdviceContent=pda.Content
                                        join tb_Patient as p on pda.PatientNo=p.No
                                        where pl.PatientNo=@PatientNo";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            sqlCommand2.CommandText = $@"select p.Name,pda.LongOrShort,dac.Name as CategoryName,pda.Content,pda.HowMuch,pda.Nnit,pda.Way,pda.Frequency,
                                        pda.StopDateTime,pl.Price from tb_PatientDoctorAdvice as pda 
                                        join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        join tb_PriceList as pl on pl.Name=pda.Content
                                        join tb_Patient as p on pda.PatientNo=p.No
                                        where p.No=@No and pl.Name not in(select AdviceContent from tb_PatientPriceList)";
            sqlCommand2.Parameters.AddWithValue("@No", Patient.No);
            DataTable DoctorAdviceTable = new DataTable();
            DataTable OtherTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlDataAdapter.SelectCommand = sqlCommand2;
            sqlDataAdapter.Fill(OtherTable);
            sqlConnection.Close();
            this.dgvInfo.DataSource = DoctorAdviceTable;
            this.dgvInfo2.DataSource = OtherTable;
            this.dgvInfo.Columns["Name"].HeaderText = "病人姓名";
            this.dgvInfo.Columns["LongOrShort"].HeaderText = "长期/短期";
            this.dgvInfo.Columns["CategoryName"].HeaderText = "医嘱类别";
            this.dgvInfo.Columns["Content"].HeaderText = "内容";
            this.dgvInfo.Columns["HowMuch"].HeaderText = "剂量";
            this.dgvInfo.Columns["Nnit"].HeaderText = "单位";
            this.dgvInfo.Columns["Way"].HeaderText = "途径";
            this.dgvInfo.Columns["Frequency"].HeaderText = "频次";
            this.dgvInfo.Columns["StopDateTime"].HeaderText = "结束时间";
            this.dgvInfo.Columns["Price"].HeaderText = "费用";
            this.dgvInfo.Columns[this.dgvInfo.Columns.Count - 1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvInfo2.Columns["Name"].HeaderText = "病人姓名";
            this.dgvInfo2.Columns["LongOrShort"].HeaderText = "长期/短期";
            this.dgvInfo2.Columns["CategoryName"].HeaderText = "医嘱类别";
            this.dgvInfo2.Columns["Content"].HeaderText = "内容";
            this.dgvInfo2.Columns["HowMuch"].HeaderText = "剂量";
            this.dgvInfo2.Columns["Nnit"].HeaderText = "单位";
            this.dgvInfo2.Columns["Way"].HeaderText = "途径";
            this.dgvInfo2.Columns["Frequency"].HeaderText = "频次";
            this.dgvInfo2.Columns["StopDateTime"].HeaderText = "结束时间";
            this.dgvInfo2.Columns["Price"].HeaderText = "费用";
            this.dgvInfo2.Columns[this.dgvInfo2.Columns.Count - 1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select OutOfficesNo from tb_MedicalRecord
                                        where No=@No";
            sqlCommand.Parameters.AddWithValue("@No", Patient.No);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //sqlConnection.Close();
            if (sqlDataReader.Read())
            {
                if (sqlDataReader["OutOfficesNo"].ToString() == "0")
                {
                    if (MessageBox.Show("出院信息未填写完整，是否再次填写?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        frm_Information frm_Information = new frm_Information();
                        frm_Information.Show();
                        this.Close();
                    }
                }
                else
                {
                    if (this.dgvInfo2.RowCount <= 1)
                    {
                        SqlCommand updateCommand = sqlConnection.CreateCommand();
                        updateCommand.CommandText = $@" update tb_MedicalRecord
                                            set IsToHospital=0
                                            where No=@No";
                        updateCommand.Parameters.AddWithValue("@No", Patient.No);
                        //sqlConnection.Open();
                        updateCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show($"编号为{Patient.No.ToString()}病人出院成功!");
                        this.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("病人仍有未缴费项目，是否向病人发送缴费信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            frm_CostInformation frm_CostInformation = new frm_CostInformation();
                            frm_CostInformation.Show();
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
