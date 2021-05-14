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
    public partial class frm_PatientListTwo : Form
    {
        public frm_PatientListTwo()
        {
            InitializeComponent();
            this.dgvPatient.AllowUserToAddRows = false;                                                //数据网格视图不允许用户添加行；
            this.dgvPatient.RowHeadersVisible = false;                                                 //数据网格视图的行标题不可见；
            this.dgvPatient.BackgroundColor = Color.White;                                             //数据网格视图的背景色设为白色；
            this.dgvPatient.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = new SqlCommand();                                                   //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                                      //将SQL命令的连接属性指向SQL连接；
            sqlCommand.CommandText =                                                                    //指定SQL命令的命令文本；
                "select * from tb_Offices;"                                                          //该命令分别查询所有院系、专业、班级，查询结果将返回多张表；
                + "select No,Name,OfficeNo from tb_Doctor;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();                                       //声明并实例化SQL数据适配器，同时借助构造函数，将其SelectCommand属性设为先前创建的SQL命令；
            sqlDataAdapter.SelectCommand = sqlCommand;                                                  //将SQL数据适配器的查询命令属性指向SQL命令；
            DataSet dataSet = new DataSet();                                                            //声明并实例化数据集，用于保存查得的多张表；
            sqlConnection.Open();                                                                       //打开SQL连接；
            sqlDataAdapter.Fill(dataSet);                                                               //SQL数据适配器读取数据，并填充数据集；
            sqlConnection.Close();                                                                      //关闭SQL连接；
            DataTable OfficesTable = dataSet.Tables[0];                                              //声明院系数据表，对应数据集的表集合中的第1张数据表；
            DataTable DoctorTable = dataSet.Tables[1];                                                   //声明专业数据表，对应数据集的表集合中的第2张数据表；
            DataRelation[] dataRelations =                                                              //声明数据关系数组；
            {
                new DataRelation                                                                        //实例化数据关系，实现科室表、医生表之间的层次关系；
                    ("Offices_Doctor"                                                                 //数据关系名称；
                    , OfficesTable.Columns["OfficesNo"]                                                     //父表的被参照列为科室表的编号列；
                    , DoctorTable.Columns["OfficeNo"]                                                //子表的参照列为医生表的科室编号列；
                    , false)                                                                            //不创建约束（父列上的唯一约束、子列上的外键约束）；
               //, new DataRelation                                                                      //实例化数据关系，实现专业表、班级表之间的层次关系；
               //     ("Major_Class"                                                                      //数据关系名称；
               //     , majorTable.Columns["No"]                                                          //父表的被参照列为专业表的编号列；
               //     , classTable.Columns["MajorNo"]                                                     //子表的参照列为班级表的专业编号列；
               //     , false)                                                                            //不创建约束（父列上的唯一约束、子列上的外键约束）；
            };
            dataSet.Relations.AddRange(dataRelations);                                                  //将数据关系数组批量加入数据集的关系集合中；
            this.tvPatient.Nodes.Clear();                                                       //树形视图的节点集合清空；
            foreach (DataRow OfficesRow in OfficesTable.Rows)                                     //遍历院系数据表中的每一数据行；
            {
                TreeNode OfficesNode = new TreeNode();                                               //声明并实例化院系节点，该节点对应当前某个院系；
                OfficesNode.Text = OfficesRow["Name"].ToString();                                 //院系节点的文本设为当前院系的名称；
                this.tvPatient.Nodes.Add(OfficesNode);                                       //将院系节点加入树形视图的（根）节点集合；
                foreach (DataRow DoctorRow in OfficesRow.GetChildRows("Offices_Doctor"))            //借助先前定义的数据关系，遍历当前院系所在数据行的子行，即下属所有医生；
                {
                    TreeNode DoctorNode = new TreeNode();                                                //声明并实例化专业节点，该节点对应当前某个专业；
                    DoctorNode.Text = DoctorRow["Name"].ToString();                                       //专业节点的文本设为当前专业的名称；
                    DoctorNode.Tag = DoctorRow["Name"];
                    OfficesNode.Nodes.Add(DoctorNode);                                                //专业节点加入当前院系节点的节点集合，成为第1级节点之一；
                    //foreach (DataRow classRow in majorRow.GetChildRows("Major_Class"))                  //借助先前定义的数据关系，遍历当前专业所在数据行的子行，即下属所有班级；
                    //{
                    //    TreeNode classNode = new TreeNode();                                            //声明并实例化班级节点，该节点对应当前某个班级；
                    //    classNode.Text = classRow["Name"].ToString();                                   //班级节点的文本设为当前班级的名称；
                    //    classNode.Tag = classRow["No"];													//班级节点的标签设为当前班级的编号；
                    //    majorNode.Nodes.Add(classNode);                                                 //班级节点加入当前专业节点的节点集合，成为第2级节点之一；
                    //}
                }
            }
        }

        private void tvPatient_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvPatient.SelectedNode.Level != 1)                                         //若树形视图的选中节点的级别不为3，即未选中班级节点；
                return;																					//则返回；
            string Doctor = (string)this.tvPatient.SelectedNode.Tag;									//将树形视图的选中节点的标签转为整型，即可获得事先保存的班级编号；
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = new SqlCommand();                                                   //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                                      //将SQL命令的连接属性指向SQL连接；
            sqlCommand.CommandText = " select No,Name,ThisNo,MainDiagnoseContent from tb_MedicalRecord WHERE Doctor=@Doctor;";          //指定SQL命令的命令文本；该命令查询当前选中班级的所有学生名单，以用作数据网格视图数据源；
            sqlCommand.Parameters.AddWithValue("@Doctor", Doctor);                                    //向SQL命令的参数集合添加参数的名称、值；
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();                                       //声明并实例化SQL数据适配器，同时借助构造函数，将其SelectCommand属性设为先前创建的SQL命令；
            sqlDataAdapter.SelectCommand = sqlCommand;                                                  //将SQL数据适配器的查询命令属性指向SQL命令；
            DataTable PatientTable = new DataTable();                                                   //声明并实例化数据表，用于保存当前选中班级的所有学生名单，以用作数据网格视图的数据源；
            sqlConnection.Open();                                                                       //打开SQL连接；
            sqlDataAdapter.Fill(PatientTable);                                                          //SQL数据适配器读取数据，并填充班级数据表；
            sqlConnection.Close();                                                                      //关闭SQL连接；
            this.dgvPatient.DataSource = PatientTable;                                                 //设置数据网格视图的数据源；
            this.dgvPatient.Columns["No"].HeaderText = "病人ID";                                         //将数据网格视图的指定列的表头文本设为中文；
            this.dgvPatient.Columns["Name"].HeaderText = "姓名";
            this.dgvPatient.Columns["ThisNo"].HeaderText = "住院号";
            this.dgvPatient.Columns["MainDiagnoseContent"].HeaderText = "入院诊断";
            this.dgvPatient.Columns[this.dgvPatient.Columns.Count - 1].AutoSizeMode =                 //数据网格视图的最后一列的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
                DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
