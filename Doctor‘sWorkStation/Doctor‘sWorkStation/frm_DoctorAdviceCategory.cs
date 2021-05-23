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
    public partial class frm_DoctorAdviceCategory : Form
    {
        private DataTable doctorAdviceTable;

        public frm_DoctorAdviceCategory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            this.dgvDoctorAdvice.RowHeadersVisible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dgvDoctorAdvice.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;        //数据网格视图的自动调整列宽模式设为显示所有单元格；

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"SELECT * FROM tb_DoctorAdviceCategory";
            sqlCommand2.CommandText = @"SELECT No,LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency FROM tb_DoctorAdvice WHERE Combo=@Combo ORDER BY No";
            sqlCommand3.CommandText = @"SELECT COUNT(1) FROM tb_DoctorAdvice WHERE Combo=@SelectCombo";
            
            if (this.txbName.Text == "")
            {
                sqlCommand2.Parameters.AddWithValue("@Combo", "");
                sqlCommand3.Parameters.AddWithValue("@SelectCombo", "");
            }
            else
            {
                sqlCommand2.Parameters.AddWithValue("@Combo", this.txbName.Text);
                sqlCommand3.Parameters.AddWithValue("@SelectCombo", txbName.Text);
            }
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();

            DataTable doctorAdviceCategoryTable = new DataTable();
            this.doctorAdviceTable = new DataTable();
            DataGridViewComboBoxColumn dgvcbxc = new DataGridViewComboBoxColumn();

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter2.SelectCommand = sqlCommand2;

            sqlConnection.Open();
            int rowCount = (int)sqlCommand3.ExecuteScalar();
            sqlDataAdapter.Fill(doctorAdviceCategoryTable);
            sqlDataAdapter2.Fill(doctorAdviceTable);
            sqlConnection.Close();

            if (rowCount > 0)
            {
                sqlCommand2.Parameters.AddWithValue("@Combo", this.txbName.Text);
            }
            else
            {
                sqlCommand2.Parameters.AddWithValue("@Combo", "");
                MessageBox.Show("该套餐不存在，可自行选择新增！");
            }

            this.dgvDoctorAdvice.Columns.Clear();     //数据网格视图的列集合清空；

            this.dgvDoctorAdvice.DataSource = doctorAdviceTable;
            this.dgvDoctorAdvice.Columns["LongOrShort"].HeaderText = "长/临";
            this.dgvDoctorAdvice.Columns["Content"].HeaderText = "医嘱内容";
            this.dgvDoctorAdvice.Columns["HowMuch"].HeaderText = "剂量";
            this.dgvDoctorAdvice.Columns["Nnit"].HeaderText = "单位";
            this.dgvDoctorAdvice.Columns["Way"].HeaderText = "途径";
            this.dgvDoctorAdvice.Columns["Frequency"].HeaderText = "频次";
            this.dgvDoctorAdvice.Columns["CategoryNo"].Visible = false;
            this.dgvDoctorAdvice.Columns["No"].Visible = false;

            dgvcbxc.DataSource = doctorAdviceCategoryTable;
            dgvcbxc.Name = "Category";
            dgvcbxc.HeaderText = "类别";
            dgvcbxc.DisplayMember = "Name";
            dgvcbxc.ValueMember = "No";
            dgvcbxc.DataPropertyName = "CategoryNo";//与数据库数据源绑定
            this.dgvDoctorAdvice.Columns.Add(dgvcbxc);
            dgvcbxc.DisplayIndex = 2;
            dgvcbxc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;                         //设置下拉框列的自动调整列宽模式为（显示）所有单元格；
            this.dgvDoctorAdvice.Columns[this.dgvDoctorAdvice.Columns.Count - 3].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //int currentNo = this.dgvDoctorAdvice.CurrentRow.Index + 1;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand insertsqlCommand = sqlConnection.CreateCommand();
            insertsqlCommand.CommandText = $@"INSERT tb_DoctorAdvice
                                             (LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency,Combo)
	                                          VALUES
	                                         (@LongOrShort,@CategoryNo,@Content,@HowMuch,@Nnit,@Way,@Frequency,@Combo)";
            //insertsqlCommand.Parameters.AddWithValue("@No", currentNo);
            insertsqlCommand.Parameters.Add("@LongOrShort", SqlDbType.VarChar, 0, "LongOrShort");
            insertsqlCommand.Parameters.Add("@CategoryNo", SqlDbType.Int, 0, "CategoryNo");
            insertsqlCommand.Parameters.Add("@Content", SqlDbType.VarChar, 0, "Content");
            insertsqlCommand.Parameters.Add("@HowMuch", SqlDbType.VarChar, 0, "HowMuch");
            insertsqlCommand.Parameters.Add("@Nnit", SqlDbType.VarChar, 0, "Nnit");
            insertsqlCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
            insertsqlCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");
            insertsqlCommand.Parameters.AddWithValue("@Combo", this.txbName.Text.Trim());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertsqlCommand;
            DataTable doctorAdviceTable = (DataTable)this.dgvDoctorAdvice.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(doctorAdviceTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //int currentNo = this.dgvDoctorAdvice.CurrentRow.Index + 1;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand insertsqlCommand = sqlConnection.CreateCommand();
            SqlCommand updatesqlCommand = sqlConnection.CreateCommand();
            insertsqlCommand.CommandText = $@"INSERT tb_DoctorAdvice
                                             (LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency,Combo)
	                                          VALUES
	                                         (@LongOrShort,@CategoryNo,@Content,@HowMuch,@Nnit,@Way,@Frequency,@Combo)";
            updatesqlCommand.CommandText = $@"update tb_DoctorAdvice
                                              set LongOrShort=@LongOrShort,CategoryNo=@CategoryNo,Content=@Content,HowMuch=@HowMuch,Nnit=@Nnit,Way=@Way,Frequency=@Frequency
                                              where No=@No AND Combo=@Combo";

            //insertsqlCommand.Parameters.AddWithValue("@No", currentNo);
            insertsqlCommand.Parameters.Add("@LongOrShort", SqlDbType.VarChar, 0, "LongOrShort");
            insertsqlCommand.Parameters.Add("@CategoryNo", SqlDbType.Int, 0, "CategoryNo");
            insertsqlCommand.Parameters.Add("@Content", SqlDbType.VarChar, 0, "Content");
            insertsqlCommand.Parameters.Add("@HowMuch", SqlDbType.VarChar, 0, "HowMuch");
            insertsqlCommand.Parameters.Add("@Nnit", SqlDbType.VarChar, 0, "Nnit");
            insertsqlCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
            insertsqlCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");
            insertsqlCommand.Parameters.AddWithValue("@Combo", this.txbName.Text.Trim());

            updatesqlCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            updatesqlCommand.Parameters.AddWithValue("@Combo", txbName.Text.Trim());
            updatesqlCommand.Parameters.Add("@LongOrShort", SqlDbType.VarChar, 0, "LongOrShort");
            updatesqlCommand.Parameters.Add("@CategoryNo",SqlDbType.Int,0, "CategoryNo");
            updatesqlCommand.Parameters.Add("@Content", SqlDbType.VarChar, 0, "Content");
            updatesqlCommand.Parameters.Add("@HowMuch", SqlDbType.VarChar, 0, "HowMuch");
            updatesqlCommand.Parameters.Add("@Nnit", SqlDbType.VarChar, 0, "Nnit");
            updatesqlCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
            updatesqlCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertsqlCommand;
            sqlDataAdapter.UpdateCommand = updatesqlCommand;
            DataTable doctorAdviceTable = (DataTable)this.dgvDoctorAdvice.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(doctorAdviceTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand deletesqlCommand = sqlConnection.CreateCommand();
            deletesqlCommand.CommandText = $@"DELETE tb_DoctorAdvice WHERE No=@No AND Combo=@Combo ";
            deletesqlCommand.Parameters.AddWithValue("@No", this.dgvDoctorAdvice.CurrentRow.Cells[0].Value);
            deletesqlCommand.Parameters.AddWithValue("@Combo", txbName.Text.Trim());
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.DeleteCommand = deletesqlCommand;
            //DataTable doctorAdviceTable = (DataTable)this.dgvDoctorAdvice.DataSource;
            sqlConnection.Open();
            //int rowAffected = sqlDataAdapter.Update(doctorAdviceTable);
            int rowAffected = deletesqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            
            DataRowView currentAdviceRowView = this.dgvDoctorAdvice.CurrentRow.DataBoundItem as DataRowView;                                    //将医嘱数据网格视图的当前行的数据绑定项，转换为数据行视图；
            DataRow currentRow = currentAdviceRowView.Row;
            currentRow.Delete();//删除当前选中行
            MessageBox.Show($"删除{rowAffected}行。");
        }
    }
}
