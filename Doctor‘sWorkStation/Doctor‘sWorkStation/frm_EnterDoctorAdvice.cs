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
    public partial class frm_EnterDoctorAdvice : Form
    {
        private int DoctorAdviceCategoryNo;

        public frm_EnterDoctorAdvice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            this.dgvDoctorAdvice.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDoctorAdvice.RowHeadersVisible = false;
            this.dgvDoctorAdvice2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDoctorAdvice2.RowHeadersVisible = false;
            this.dgvDoctorAdvice2.ReadOnly = true;

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
            SqlCommand sqlCommand4 = sqlConnection.CreateCommand();

            sqlCommand.CommandText = $@"select * from tb_PatientDoctorAdvice as pda join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        where PatientNo=@PatientNo";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);

            sqlCommand2.CommandText = $@"select p.Name,mr.BedNo,p.Gender,p.Birthday from tb_MedicalRecord as mr join tb_Patient as p on mr.No=p.No
                                        where p.No=@No";
            sqlCommand2.Parameters.AddWithValue("@No", Patient.No);

            sqlCommand3.CommandText = $@"SELECT LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency FROM tb_DoctorAdvice AS DA 
                                         JOIN tb_DoctorAdviceCategory AS DAC ON DA.CategoryNo=DAC.No
                                         WHERE Combo=''";
            sqlCommand4.CommandText = @"SELECT * FROM tb_DoctorAdviceCategory";

            DataTable DoctorAdviceTable = new DataTable();
            DataTable NewTable = new DataTable();
            DataTable AdviceCategoryTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;

            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlDataAdapter.SelectCommand = sqlCommand3;
            sqlDataAdapter.Fill(NewTable);
            sqlDataAdapter.SelectCommand = sqlCommand4;
            sqlDataAdapter.Fill(AdviceCategoryTable);
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            lblPatientID.Text = $"病人ID：{Patient.No}";
            if (sqlDataReader.Read())
            {
                lblName.Text = $"姓名：{sqlDataReader["Name"].ToString()}";
                lblGender.Text = $"性别：{sqlDataReader["Gender"].ToString()}";
                lblAgo.Text = $"出生日期：{((DateTime)sqlDataReader["Birthday"]).ToString()}";
                lblBedNo.Text = $"床号：{sqlDataReader["BedNo"].ToString()}";
            }
            sqlConnection.Close();
            this.dgvDoctorAdvice.DataSource = DoctorAdviceTable;
            ShowTableOne();
            this.dgvDoctorAdvice2.DataSource = NewTable;

            DataGridViewComboBoxColumn dgvcbxc = new DataGridViewComboBoxColumn();
            dgvcbxc.DataSource = AdviceCategoryTable;
            this.dgvDoctorAdvice2.Columns["CategoryNo"].Visible = false;
            dgvcbxc.Name = "CategoryName";
            dgvcbxc.HeaderText = "类别";
            dgvcbxc.DisplayMember = "Name";
            dgvcbxc.ValueMember = "No";
            dgvcbxc.DataPropertyName = "CategoryNo";//与数据库数据源绑定
            this.dgvDoctorAdvice2.Columns.Add(dgvcbxc);
            dgvcbxc.DisplayIndex = 2;
            ShowTableTwo();
            
            CalendarColumn calendar = new CalendarColumn();
            calendar.Name = "StartDateTime";
            calendar.HeaderText = "下达时间";
            this.dgvDoctorAdvice2.Columns.Add(calendar);
            calendar.DisplayIndex = 8;
            CalendarColumn calendar2 = new CalendarColumn();
            calendar2.Name = "DoDateTime";
            calendar2.HeaderText = "执行时间";
            this.dgvDoctorAdvice2.Columns.Add(calendar2);
            calendar2.DisplayIndex = 9;
            CalendarColumn calendar3 = new CalendarColumn();
            calendar3.Name = "StopDateTime";
            calendar3.HeaderText = "结束时间";
            this.dgvDoctorAdvice2.Columns.Add(calendar3);
            calendar3.DisplayIndex = 10;

            this.dgvDoctorAdvice2.Columns[this.dgvDoctorAdvice2.Columns.Count - 1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void rbnAll_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_PatientDoctorAdvice as pda join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        where PatientNo=@PatientNo";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            DataTable DoctorAdviceTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlConnection.Close();
            this.dgvDoctorAdvice.DataSource = DoctorAdviceTable;
            ShowTableOne();
        }

        private void rbnLong_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_PatientDoctorAdvice as pda join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        where PatientNo=@PatientNo And pda.LongOrShort='{rbnLong.Text}'";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            DataTable DoctorAdviceTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlConnection.Close();
            this.dgvDoctorAdvice.DataSource = DoctorAdviceTable;
            ShowTableOne();
        }

        private void rbnShort_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_PatientDoctorAdvice as pda join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        where PatientNo=@PatientNo And pda.LongOrShort='{rbnShort.Text}'";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            DataTable DoctorAdviceTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlConnection.Close();
            this.dgvDoctorAdvice.DataSource = DoctorAdviceTable;
            ShowTableOne();
        }

        private void cmsMenu_Opening(object sender, CancelEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select distinct Combo from tb_DoctorAdvice";
            DataTable ComboTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(ComboTable);
            sqlConnection.Close();
            //浮动菜单的设置
            this.cmsMenu.Items.Clear();
            //在菜单里添加标题
            ToolStripMenuItem title = new ToolStripMenuItem();
            title.Text = "选择医嘱套餐";
            title.Enabled = false;
            this.cmsMenu.Items.Add(title);
            //在菜单里添加分割线
            ToolStripSeparator isolate = new ToolStripSeparator();
            this.cmsMenu.Items.Add(isolate);
            int count = ComboTable.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                this.cmsMenu.Items.Add(ComboTable.Rows[i]["Combo"].ToString());
                //获取数据表中某一列的数据
            }
        }

        private void ShowTableOne()
        {
            this.dgvDoctorAdvice.Columns["DoctorAdviceNo"].Visible = false;
            this.dgvDoctorAdvice.Columns["PatientNo"].Visible = false;
            this.dgvDoctorAdvice.Columns["No"].Visible = false;
            this.dgvDoctorAdvice.Columns["CategoryNo"].Visible = false;
            this.dgvDoctorAdvice.Columns["Name"].DisplayIndex = 3;
            this.dgvDoctorAdvice.ReadOnly = true;
            this.dgvDoctorAdvice.Columns["LongOrShort"].HeaderText = "长期/短期";
            this.dgvDoctorAdvice.Columns["Name"].HeaderText = "医嘱类别";
            this.dgvDoctorAdvice.Columns["StartDateTime"].HeaderText = "下达时间";
            this.dgvDoctorAdvice.Columns["Content"].HeaderText = "医嘱内容";
            this.dgvDoctorAdvice.Columns["HowMuch"].HeaderText = "剂量";
            this.dgvDoctorAdvice.Columns["Nnit"].HeaderText = "单位";
            this.dgvDoctorAdvice.Columns["Way"].HeaderText = "途径";
            this.dgvDoctorAdvice.Columns["Frequency"].HeaderText = "频次";
            this.dgvDoctorAdvice.Columns["DoDateTime"].HeaderText = "执行时间";
            this.dgvDoctorAdvice.Columns["StopDateTime"].HeaderText = "结束时间";
        }
        private void ShowTableTwo()
        {
            this.dgvDoctorAdvice2.Columns["LongOrShort"].HeaderText = "长期/短期";
            this.dgvDoctorAdvice2.Columns["CategoryName"].HeaderText = "医嘱类别";
            this.dgvDoctorAdvice2.Columns["Content"].HeaderText = "内容";
            this.dgvDoctorAdvice2.Columns["HowMuch"].HeaderText = "剂量";
            this.dgvDoctorAdvice2.Columns["Nnit"].HeaderText = "单位";
            this.dgvDoctorAdvice2.Columns["Way"].HeaderText = "途径";
            this.dgvDoctorAdvice2.Columns["Frequency"].HeaderText = "频次";
            
        }

        private void cmsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.dgvDoctorAdvice2.AutoGenerateColumns = false;//防止datagridview中的列自动变化

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency FROM tb_DoctorAdvice AS DA 
                                         JOIN tb_DoctorAdviceCategory AS DAC ON DA.CategoryNo=DAC.No
                                         WHERE Combo='{e.ClickedItem.Text}'";
            DataTable NewTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(NewTable);
            sqlConnection.Close();
            this.dgvDoctorAdvice2.DataSource = NewTable;
            ShowTableTwo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvDoctorAdvice2.CurrentRow.Cells["StartDateTime"].Value != null
                && this.dgvDoctorAdvice2.CurrentRow.Cells["DoDateTime"].Value != null
                && this.dgvDoctorAdvice2.CurrentRow.Cells["StopDateTime"].Value != null)
            {
                SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
                sqlConnection.ConnectionString =
                    "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $@"insert tb_PatientDoctorAdvice(PatientNo,LongOrShort,CategoryNo,StartDateTime,
                                        Content,HowMuch,Nnit,Way,Frequency,DoDateTime,StopDateTime)
                                        values(@PatientNo,@LongOrShort,@CategoryNo,@StartDateTime,
                                               @Content,@HowMuch,@Nnit,@Way,@Frequency,@DoDateTime,@StopDateTime)";
                sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
                sqlCommand.Parameters.AddWithValue("@LongOrShort", this.dgvDoctorAdvice2.CurrentRow.Cells["LongOrShort"].Value);
                //sqlCommand.Parameters.AddWithValue("@CategoryNo", this.dgvDoctorAdvice2.CurrentRow.Cells["CategoryName"].Value);
                sqlCommand.Parameters.AddWithValue("@CategoryNo", this.dgvDoctorAdvice2.CurrentRow.Cells["CategoryNo"].FormattedValue);
                sqlCommand.Parameters.AddWithValue("@StartDateTime", (DateTime)this.dgvDoctorAdvice2.CurrentRow.Cells["StartDateTime"].Value);
                sqlCommand.Parameters.AddWithValue("@Content", this.dgvDoctorAdvice2.CurrentRow.Cells["Content"].Value);
                sqlCommand.Parameters.AddWithValue("@HowMuch", this.dgvDoctorAdvice2.CurrentRow.Cells["HowMuch"].Value);
                sqlCommand.Parameters.AddWithValue("@Nnit", this.dgvDoctorAdvice2.CurrentRow.Cells["Nnit"].Value);
                sqlCommand.Parameters.AddWithValue("@Way", this.dgvDoctorAdvice2.CurrentRow.Cells["Way"].Value);
                sqlCommand.Parameters.AddWithValue("@Frequency", this.dgvDoctorAdvice2.CurrentRow.Cells["Frequency"].Value);
                sqlCommand.Parameters.AddWithValue("@DoDateTime", (DateTime)this.dgvDoctorAdvice2.CurrentRow.Cells["DoDateTime"].Value);
                sqlCommand.Parameters.AddWithValue("@StopDateTime", (DateTime)this.dgvDoctorAdvice2.CurrentRow.Cells["StopDateTime"].Value);

                sqlConnection.Open();
                if (MessageBox.Show("现在就提交新开医嘱吗?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("提交成功！");
                }
                sqlConnection.Close();
                //MessageBox.Show("新增成功！");
            }
            else
            {
                MessageBox.Show("时间不能为空！");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.dgvDoctorAdvice2.ReadOnly = false;
        }

        private void rbnAllShow_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_PatientDoctorAdvice as pda join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        where PatientNo=@PatientNo";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            DataTable DoctorAdviceTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlConnection.Close();
            this.dgvDoctorAdvice.DataSource = DoctorAdviceTable;
            ShowTableOne();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((DateTime)this.dgvDoctorAdvice.CurrentRow.Cells["DoDateTime"].Value > DateTime.Now)
            {
                SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
                sqlConnection.ConnectionString =
                    "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $@"delete tb_PatientDoctorAdvice
                                        where PatientNo=@PatientNo And DoctorAdviceNo=@DoctorAdviceNo";
                sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
                sqlCommand.Parameters.AddWithValue("@DoctorAdviceNo", this.dgvDoctorAdvice.CurrentRow.Cells["DoctorAdviceNo"].Value);
                sqlConnection.Open();
                if (MessageBox.Show("确定删除吗?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("删除成功！");
                    DataRowView currentAdviceRowView = this.dgvDoctorAdvice.CurrentRow.DataBoundItem as DataRowView;                                    //将医嘱数据网格视图的当前行的数据绑定项，转换为数据行视图；
                    DataRow currentRow = currentAdviceRowView.Row;
                    currentRow.Delete();//删除当前选中行
                }
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("医嘱已执行，不可删除！");
            }
        }

        private void rbnHadDo_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_PatientDoctorAdvice as pda join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        where PatientNo=@PatientNo and DoDateTime > GETDATE() ";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            DataTable DoctorAdviceTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlConnection.Close();
            this.dgvDoctorAdvice.DataSource = DoctorAdviceTable;
            ShowTableOne();
        }

        private void rbnRecord_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_PatientDoctorAdvice as pda join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
                                        where PatientNo=@PatientNo and StopDateTime < GETDATE() ";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            DataTable DoctorAdviceTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DoctorAdviceTable);
            sqlConnection.Close();
            this.dgvDoctorAdvice.DataSource = DoctorAdviceTable;
            ShowTableOne();
        }
    }
}
