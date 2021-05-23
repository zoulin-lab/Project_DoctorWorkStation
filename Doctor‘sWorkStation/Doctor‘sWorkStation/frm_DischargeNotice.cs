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

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select p.Name,pda.LongOrShort,dac.Name as CategoryName,pda.Content,pda.HowMuch,pda.Nnit,pda.Way,pda.Frequency,
                                        pda.StopDateTime,pl.Price from tb_PatientDoctorAdvice as pda 
                                        join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        join tb_PriceList as pl on pl.Name=pda.Content
                                        join tb_Patient as p on pda.PatientNo=p.No
                                        where PatientNo=@PatientNo";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            DataTable DoctorAdviceTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlConnection.Close();
            this.dgvInfo.DataSource = DoctorAdviceTable;
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
        }
    }
}
