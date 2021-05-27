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
    public partial class frm_CostInformation : Form
    {
        private DataTable SelectedPriceTable;
        private DataTable CostTable;

        public frm_CostInformation()
        {
            InitializeComponent();
            this.dgvCostInfo1.RowHeadersVisible = false;
            this.dgvCostInfo1.BackgroundColor = Color.White;
            this.dgvCostInfo2.BackgroundColor = Color.White;
            this.dgvCostInfo2.RowHeadersVisible = false;
            this.dgvCostInfo1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCostInfo2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            lblPrice.Visible = false;

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = $@"select Content,Price from tb_PatientDoctorAdvice as pda 
                                        join tb_PriceList as pl on pda.Content=pl.Name
                                        where Content not in (select AdviceContent from tb_PatientPriceList
                                        where PatientNo=@PatientNo) and PatientNo=@PatientNo";
            sqlCommand.Parameters.AddWithValue("@PatientNo", Patient.No);//参数
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand2.CommandText = $@"select AdviceContent,Price from tb_PatientPriceList
                                         where PatientNo=@PatientNo";
            sqlCommand2.Parameters.AddWithValue("@PatientNo", Patient.No);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            this.CostTable = new DataTable();
            this.SelectedPriceTable = new DataTable();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(CostTable);
            sqlDataAdapter.SelectCommand = sqlCommand2;
            sqlDataAdapter.Fill(SelectedPriceTable);
            sqlConnection.Close();
            
            this.dgvCostInfo1.DataSource = CostTable;
            this.dgvCostInfo2.DataSource = SelectedPriceTable;
            this.dgvCostInfo1.Columns["Content"].HeaderText = "项目";
            this.dgvCostInfo1.Columns["Price"].HeaderText = "费用";
            this.dgvCostInfo2.Columns["AdviceContent"].HeaderText = "项目";
            this.dgvCostInfo2.Columns["Price"].HeaderText = "费用";

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.Name = "link_More";
            link.HeaderText = "更多";
            link.DefaultCellStyle.NullValue = "详情";
            this.dgvCostInfo1.Columns.Add(link);
            this.dgvCostInfo1.Columns["link_More"].DisplayIndex = 2;

            DataGridViewLinkColumn link2 = new DataGridViewLinkColumn();
            link2.Name = "link2_More";
            link2.HeaderText = "更多";
            link2.DefaultCellStyle.NullValue = "详情";
            this.dgvCostInfo2.Columns.Add(link2);
            this.dgvCostInfo2.Columns["link2_More"].DisplayIndex = 2;

            
            this.dgvCostInfo1.Columns[this.dgvCostInfo1.Columns.Count -1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCostInfo2.Columns[this.dgvCostInfo2.Columns.Count - 1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAdvancePayment_Click(object sender, EventArgs e)
        {
            if (this.dgvCostInfo1.RowCount == 1)                                                              //若课程数据网格视图内的行计数等于0；
                return;                                                                                     //返回；
            DataRowView currentPriceRowView =
                this.dgvCostInfo1.CurrentRow.DataBoundItem as DataRowView;                                    //将课程数据网格视图的当前行的数据绑定项，转换为数据行视图；
            DataRow                                                                                         //声明数据行；
                currentPriceRow = currentPriceRowView.Row													//通过当前的数据行视图，获取其相应的数据行；
                , selectedPriceRow = this.SelectedPriceTable.NewRow();									//已选课程数据行则通过已选课程数据表的方法NewRow来新建；随后该行的状态为分离；
            selectedPriceRow["AdviceContent"] = currentPriceRow["Content"];												//逐一将当前课程数据行的各列值，赋予已选课程数据行的相应列；
            selectedPriceRow["Price"] = currentPriceRow["Price"];
            this.SelectedPriceTable.Rows.Add(selectedPriceRow);											//已选课程数据行加入已选课程数据表；随后该行的状态为添加；
            currentPriceRow.Delete();                                                                      //当前课程数据行删除；随后该行的状态为删除；
            this.lblPrice.Visible = true;
            this.lblPrice.Text =																		//在标签中显示已选课程的学分总和；
                $"费用共{this.SelectedPriceTable.Compute("SUM(Price)", "")}元";								//借助已选课程数据表的方法Compute，实现简单计算，例如聚合；
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (this.dgvCostInfo2.RowCount == 0)                                                      //若已选课程数据网格视图内的行计数等于0；
                return;                                                                                     //返回；
            DataRowView PriceRowView =
                this.dgvCostInfo2.CurrentRow.DataBoundItem as DataRowView;                            //将已选课程数据网格视图的当前行的数据绑定项，转换为数据行视图；
            DataRow PriceRow = PriceRowView.Row;                                          //通过当前的数据行视图，获取其相应的数据行；
            if (PriceRow.RowState != DataRowState.Added)                                           //若已选课程数据行的行状态并非添加；
                return;                                                                                     //返回；
            string Content = PriceRow["AdviceContent"].ToString();
            DataRow deletedPriceRow =																		//声明已删课程数据行（即先前从课程数据表中删除的数据行）；
                this.CostTable.Select($"Content='{Content}'", "", DataViewRowState.Deleted)[0];			//已删课程数据行可通过课程数据表的方法Select查得，该方法接受查询条件、排序条件、行状态条件等参数，并返回数据行数组；
            deletedPriceRow.RejectChanges();																//已删课程数据行拒绝更改，即回滚先前对其执行的删除；随后该行的状态为未更改；
            this.SelectedPriceTable.Rows.Remove(PriceRow);
            this.lblPrice.Text =                                                                       //在标签中显示已选课程的学分总和；
                 $"费用共{this.SelectedPriceTable.Compute("SUM(Price)", "")}元";								//借助已选课程数据表的方法Compute，实现简单计算，例如聚合；
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                              //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                             //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand insertCommand = new SqlCommand();                                                    //声明并实例化用于插入的SQL命令；
            insertCommand.Connection = sqlConnection;                                                       //将SQL命令的连接属性指向SQL连接；
            insertCommand.CommandText =
                @"insert tb_PatientPriceList(PatientNo,AdviceContent,Price)
                  values(@PatientNo,@AdviceContent,@Price)";                                              //指定SQL命令的命令文本；该命令插入选课记录；
            insertCommand.Parameters.AddWithValue("@PatientNo", Patient.No);
            insertCommand.Parameters.Add("@AdviceContent", SqlDbType.VarChar, 100, "AdviceContent");
            insertCommand.Parameters.Add("@Price",SqlDbType.Decimal,1,"Price");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();                                           //声明并实例化SQL数据适配器；
            sqlDataAdapter.InsertCommand = insertCommand;
            
            if (MessageBox.Show("确定向病人发送缴费信息吗?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {                                     //将SQL数据适配器的插入命令属性指向SQL命令；
                sqlConnection.Open();                               //SQL数据适配器根据学生数据表提交更新，并返回受影响行数；
                int rowCount = sqlDataAdapter.Update(this.SelectedPriceTable);
                sqlConnection.Close();
                if (rowCount == 0)
                {
                    MessageBox.Show("未新增项目！请重新选择项目！");
                }
                else
                {
                    MessageBox.Show("发送成功！");
                    frm_DischargeNotice frm_DischargeNotice = new frm_DischargeNotice();
                    frm_DischargeNotice.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCostInfo1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCostInfo1.Columns[e.ColumnIndex].Name == "link_More" && e.RowIndex >= 0)
            {
                frm_Information frm_Information = new frm_Information();
                frm_Information.Show();
            }
        }
    }
}

