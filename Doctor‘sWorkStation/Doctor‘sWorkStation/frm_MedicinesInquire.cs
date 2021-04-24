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
    public partial class frm_MedicinesInquire : Form
    {
        public frm_MedicinesInquire()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            palMedicinesInfo.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = " SELECT * from tb_Medicines where CName=@CName";
            sqlCommand.Parameters.AddWithValue("@CName",txbName.Text.Trim());//参数
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read()) 
            {
                lblCName.Text = $"中文名称：{sqlDataReader["CName"].ToString()}";
                lblEName.Text = $"英文名称：{sqlDataReader["EName"].ToString()}";
                txbFuntion.Text = sqlDataReader["PharmacologicalActions"].ToString();
                txbUsage.Text = sqlDataReader["Usage"].ToString();
                txbTaboo.Text = sqlDataReader["Taboo"].ToString();
            }
            else
            {
                MessageBox.Show("本医院未收录此药品!");
            }
            sqlDataReader.Close();
            palMedicinesInfo.Visible = true;
        }
    }
}
