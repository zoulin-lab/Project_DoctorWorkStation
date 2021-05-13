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
    public partial class frm_NewPatient : Form
    {
        /// <summary>
        /// 学生数据表；
        /// </summary>
        private DataTable PatientTable;
        /// <summary>
        /// 当前页的数据视图；
        /// </summary>
        private DataView CurrentPageView;
        /// <summary>
        /// 每页大小；
        /// </summary>
        private int PageSize;
        /// <summary>
        /// 当前页号；
        /// </summary>
        private int CurrentPageNo;
        /// <summary>
        /// 最大页号；
        /// </summary>
        private int MaxPageNo;

        private void RefreshRowFilter()
        => this.CurrentPageView.RowFilter =                                                                //设置学生数据视图的行筛选条件，即筛选当前页的记录；
                $"RowID >{(this.CurrentPageNo - 1) * this.PageSize}"
                + $"AND RowID <={this.CurrentPageNo * this.PageSize}";                                      //根据当前页号、每页大小，计算相应的行编号范围，并作为行筛选条件；


        public frm_NewPatient()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            this.dgvNewPatient.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;        //数据网格视图的自动调整列宽模式设为显示所有单元格；
            this.dgvNewPatient.ReadOnly = true;
            

            this.PageSize = 5;                                                                             //设置每页大小为10（行记录）；
            this.CurrentPageNo = 1;                                                                         //设置当前页号为1；

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            sqlCommand.CommandText =$@"select p.No,p.Name,p.Gender,p.IsMarried,p.Nation,p.Career,p.Address,p.WorkPlace,p.Birthday,o.Name as OfficeName from tb_Patient as p
                                       join tb_Offices as o on p.OfficeNo=o.OfficesNo 
                                       where OfficeNo=@OfficeNo and No not in (select No from tb_MedicalRecord) ";
            sqlCommand.Parameters.AddWithValue("OfficeNo", Doctor.OfficeNo);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            this.PatientTable = new DataTable();

            this.PatientTable.TableName = "Patient";                                                   //设置病人数据表的表名；由于该查询访问多张表，数据适配器无法自动指定表名，故需手动指定表名；
            DataColumn rowIdColumn = new DataColumn();                                                      //声明并实例化数据列，用于保存行编号；
            rowIdColumn.ColumnName = "RowID";                                                               //设置数据列的名称；
            rowIdColumn.DataType = typeof(int);                                                             //设置数据列的类型；类型需借助typeof获取；
            rowIdColumn.AutoIncrement = true;                                                               //设置数据列为自增列；
            rowIdColumn.AutoIncrementSeed = 1;                                                              //设置数据列的自增种子为1；
            rowIdColumn.AutoIncrementStep = 1;                                                              //设置数据列的自增步长为1；
            this.PatientTable.Columns.Add(rowIdColumn);                                                     //数据列加入本窗体的学生数据表的列集合；

            sqlConnection.Open();
            sqlDataAdapter.Fill(PatientTable);
            this.dgvNewPatient.DataSource = PatientTable;
            sqlConnection.Close();

            this.MaxPageNo =
                (int)Math.Ceiling((double)this.PatientTable.Rows.Count / (double)this.PageSize);            //根据学生数据表的行集合的计数与每页大小，计算最大页号；
            this.CurrentPageView = new DataView();                                                          //实例化本窗体的学生数据视图，用于筛选当前页的记录；
            this.CurrentPageView.Table = this.PatientTable;                                                 //设置学生数据视图对应的数据表；
            this.CurrentPageView.Sort = "RowID ASC";                                                        //设置学生数据视图的排序条件，即行编号；
            this.RefreshRowFilter();																		//刷新行筛选条件，即筛选当前页的记录；
            this.dgvNewPatient.Columns.Clear();                                                               //数据网格视图的列集合清空；
            this.dgvNewPatient.DataSource = this.CurrentPageView;                                             //将数据网格视图的数据源设为当前页学生的视图；
            //this.dgvNewPatient.Columns["No"].HeaderText = "学号";												//将数据网格视图的指定列的表头文本设为中文；
            //this.dgvNewPatient.Columns["Name"].HeaderText = "姓名";
            //this.dgvNewPatient.Columns["Gender"].HeaderText = "生日";
            //this.dgvNewPatient.Columns["IsMarried"].HeaderText = "电话";
            //this.dgvNewPatient.Columns["Nation"].HeaderText = "学号";												
            //this.dgvNewPatient.Columns["Car"].HeaderText = "姓名";
            //this.dgvNewPatient.Columns["BirthDate"].HeaderText = "生日";
            //this.dgvNewPatient.Columns["Phone"].HeaderText = "电话";
            //this.dgvNewPatient.Columns["No"].HeaderText = "学号";												
            //this.dgvNewPatient.Columns["Name"].HeaderText = "姓名";
            this.dgvNewPatient.Columns["RowID"].Visible = false;                                               //将数据网格视图的指定列设为不可见；
            this.lblTip.Text = $"每页显示{PageSize}条，共{MaxPageNo}页，当前为第1页！";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_FirstAge frm_FirstAge = new frm_FirstAge();
            frm_FirstAge.Show();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {

            //string PatientID = dgvNewPatient.CurrentRow.Cells["病人ID"].Value.ToString();
            //string TreatedDoctor = dgvNewPatient.CurrentRow.Cells["经治医生"].Value.ToString();
            //if (TreatedDoctor == Doctor.Name||TreatedDoctor=="")
            //{
            //    SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            //    sqlConnection.ConnectionString =
            //        "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            //    SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接； 
            //    sqlCommand.CommandText = $@"UPDATE tb_MedicalRecord SET IsToHospital=1,Doctor=@NewDoctor WHERE No=@No AND Doctor=@Doctor";
            //    sqlCommand.Parameters.AddWithValue("@No", PatientID);
            //    sqlCommand.Parameters.AddWithValue("@Doctor", TreatedDoctor);
            //    sqlCommand.Parameters.AddWithValue("@NewDoctor", Doctor.Name);
            //    sqlConnection.Open();
            //    int rowAffected = sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    MessageBox.Show("成功新建病人！");
            //    this.Close();
            //    frm_FirstAge frm_FirstAge = new frm_FirstAge();
            //    frm_FirstAge.Show();
            //}
            //else
            //{
            //    MessageBox.Show("请选择自己负责的病人！");
            //}

            Patient.No = this.dgvNewPatient.CurrentRow.Cells["No"].Value.ToString();
            frm_NewPatientWrite frm_NewPatientWrite = new frm_NewPatientWrite();
            frm_NewPatientWrite.Show();
            this.Close();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageNo > 1)                                                                     //若当前页号大于1；
                this.CurrentPageNo--;                                                                       //则当前页号递减；
            this.lblTip.Text = $"每页显示{PageSize}条，共{this.MaxPageNo}页，当前为第{CurrentPageNo}页！";
            this.RefreshRowFilter();                                                                        //刷新行筛选条件，即筛选当前页的记录；

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageNo < this.MaxPageNo)                                                        //若当前页号尚未超出最大页号；
                this.CurrentPageNo++;                                                                       //则当前页号递增；
            this.lblTip.Text = $"每页显示{PageSize}条，共{this.MaxPageNo}页，当前为第{CurrentPageNo}页！";
            this.RefreshRowFilter();                                                                        //刷新行筛选条件，即筛选当前页的记录；

        }

        private void frm_NewPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_FirstAge frm_FirstAge = new frm_FirstAge();
            frm_FirstAge.Show();
         
        }
    }
}
