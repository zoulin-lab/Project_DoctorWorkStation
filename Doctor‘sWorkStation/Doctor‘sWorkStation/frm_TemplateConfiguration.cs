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
    public partial class frm_TemplateConfiguration : Form
    {
        private DataTable TemplateTable;
        private DataTable MyTemplateTable;

        public frm_TemplateConfiguration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            this.dgvTemplate.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;        //数据网格视图的自动调整列宽模式设为显示所有单元格；
            this.dgvHadPickedTemplate.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText = $@"select * from tb_Template 
                                                          where No NOT IN 
                                                          (select t.No from tb_DoctorChooseTemplate as dct
                                                          join tb_Template as t  on DCT.TemplateNo=T.No
                                                          where dct.DoctorNo=@DoctorNo1)";
            sqlCommand.Parameters.AddWithValue("@DoctorNo1", Doctor.No);//参数
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            this.TemplateTable = new DataTable();
            this.MyTemplateTable = new DataTable();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(TemplateTable);
            sqlDataAdapter.SelectCommand.CommandText = $@"select t.No,t.Name,t.Category from tb_DoctorChooseTemplate as dct
                                                          join tb_Template as t  on DCT.TemplateNo=T.No
                                                          where dct.DoctorNo=@DoctorNo";
            sqlCommand.Parameters.AddWithValue("@DoctorNo", Doctor.No);//参数
            sqlDataAdapter.Fill(MyTemplateTable);
            sqlConnection.Close();
            this.dgvTemplate.DataSource = TemplateTable;
            this.dgvHadPickedTemplate.DataSource = MyTemplateTable;
            this.dgvTemplate.Columns[this.dgvTemplate.Columns.Count - 1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHadPickedTemplate.Columns[this.dgvHadPickedTemplate.Columns.Count - 1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"{dgvTemplate.RowCount.ToString()}");
            if (this.dgvTemplate.RowCount == 1)         //等于1而不是等于0的原因是网格内还有一行标题   //若课程数据网格视图内的行计数等于0；
                return;                                                                                     //返回；
            DataRowView currentTemplateRowView =
                this.dgvTemplate.CurrentRow.DataBoundItem as DataRowView;                                    //将课程数据网格视图的当前行的数据绑定项，转换为数据行视图；
            DataRow                                                                                         //声明数据行；
                currentTemolateRow = currentTemplateRowView.Row													//通过当前的数据行视图，获取其相应的数据行；
                , MyTemplateRow = this.MyTemplateTable.NewRow();									//已选课程数据行则通过已选课程数据表的方法NewRow来新建；随后该行的状态为分离；
            MyTemplateRow["No"] = currentTemolateRow["No"];												//逐一将当前课程数据行的各列值，赋予已选课程数据行的相应列；
            MyTemplateRow["Name"] = currentTemolateRow["Name"];
            MyTemplateRow["Category"] = currentTemolateRow["Category"];
            this.MyTemplateTable.Rows.Add(MyTemplateRow);											//已选课程数据行加入已选课程数据表；随后该行的状态为添加；
            currentTemolateRow.Delete();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (this.dgvHadPickedTemplate.RowCount == 0)                                                      //若已选课程数据网格视图内的行计数等于0；
                return;                                                                                     //返回；
            DataRowView MyTemplateRowView =
                this.dgvHadPickedTemplate.CurrentRow.DataBoundItem as DataRowView;                            //将已选课程数据网格视图的当前行的数据绑定项，转换为数据行视图；
            DataRow MyTemplateRow = MyTemplateRowView.Row;                                          //通过当前的数据行视图，获取其相应的数据行；
            if (MyTemplateRow.RowState != DataRowState.Added)                                           //若已选课程数据行的行状态并非添加；
                return;                                                                                     //返回；
            string TemplateNo = MyTemplateRow["No"].ToString();											//获取当前课程数据行的课程编号；
            DataRow deletedTemplateRow =																		//声明已删课程数据行（即先前从课程数据表中删除的数据行）；
                this.TemplateTable.Select($"No='{TemplateNo}'", "", DataViewRowState.Deleted)[0];			//已删课程数据行可通过课程数据表的方法Select查得，该方法接受查询条件、排序条件、行状态条件等参数，并返回数据行数组；
            deletedTemplateRow.RejectChanges();																//已删课程数据行拒绝更改，即回滚先前对其执行的删除；随后该行的状态为未更改；
            this.MyTemplateTable.Rows.Remove(MyTemplateRow);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                              //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                             //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand insertCommand = new SqlCommand();                                                    //声明并实例化用于插入的SQL命令；
            insertCommand.Connection = sqlConnection;                                                       //将SQL命令的连接属性指向SQL连接；
            insertCommand.CommandText =
                @"INSERT tb_DoctorChooseTemplate(DoctorNo,TemplateNo)
					VALUES(@DoctorNo,@TemplateNo);";                                              //指定SQL命令的命令文本；该命令插入选课记录；
            insertCommand.Parameters.AddWithValue("@DoctorNo", Doctor.No);                            //向SQL命令的参数集合添加参数的名称、SQL Server数据类型、长度（仅用于定长类型）、所绑定的数据表中的列名；
            insertCommand.Parameters.Add("@TemplateNo", SqlDbType.Char, 4, "No");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();                                           //声明并实例化SQL数据适配器；
            sqlDataAdapter.InsertCommand = insertCommand;                                                   //将SQL数据适配器的插入命令属性指向SQL命令；
            sqlConnection.Open();                                                                           //打开SQL连接；
            int rowAffected = sqlDataAdapter.Update(this.MyTemplateTable);                              //SQL数据适配器根据学生数据表提交更新，并返回受影响行数；
            sqlConnection.Close();                                                                          //关闭SQL连接；
            MessageBox.Show($"提交{rowAffected}行。");
        }
    }
}
