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
using System.IO;
using System.Drawing.Imaging;
using static System.Environment;

namespace Doctor_sWorkStation
{
    public partial class frm_Information : Form
    {
        public frm_Information()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            if (Patient.Name != "")
            {
                SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
                sqlConnection.ConnectionString =
                        "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
                sqlCommand.CommandText = " SELECT * FROM tb_Offices;";
                sqlCommand2.CommandText = $@"SELECT p.No AS Patient,p.Name,p.Gender,p.Career,p.Birthday,mr.ThisNo,MR.InHospitalCount,MR.OfficesNo,p.Picture,mr.InDate,MR.OutOfficesNo,MR.OutDate,MR.OtherSitiuation  
                                         FROM tb_Patient AS P JOIN tb_MedicalRecord AS MR ON P.No = MR.No
                                         WHERE p.Name=@Name";
                sqlCommand2.Parameters.AddWithValue("@Name", Patient.Name); //参数 
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//数据适配器 
                sqlDataAdapter.SelectCommand = sqlCommand;
                DataTable OfficesTable = new DataTable();//用于存放查到的表
                sqlConnection.Open();
                sqlDataAdapter.Fill(OfficesTable);
                this.cbxInHospitalRoom.DataSource = OfficesTable;
                this.cbxOutHospitalRoom.DataSource = OfficesTable;
                this.cbxInHospitalRoom.DisplayMember = "Name";
                this.cbxInHospitalRoom.ValueMember = "OfficesNo";
                this.cbxOutHospitalRoom.DisplayMember = "Name";
                this.cbxOutHospitalRoom.ValueMember = "OfficesNo";
                SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();//索引器

                //用于图片
                byte[] photoBytes = null;

                if (sqlDataReader.Read())
                {
                    this.txbNo.Text = sqlDataReader["Patient"].ToString();
                    this.txbName.Text = sqlDataReader["Name"].ToString();
                    this.rdbMale.Checked = (bool)sqlDataReader["Gender"];
                    this.rdbFemale.Checked = !(bool)sqlDataReader["Gender"];
                    this.txbCareer.Text = sqlDataReader["Career"].ToString();
                    this.dtpBirthday.Value = (DateTime)sqlDataReader["Birthday"];
                    this.txbInHospitalNo.Text = sqlDataReader["ThisNo"].ToString();
                    this.txbInHospitalCount.Text = sqlDataReader["InHospitalCount"].ToString();
                    this.cbxInHospitalRoom.SelectedValue = (int)sqlDataReader["OfficesNo"];
                    this.dtpInDate.Value = (DateTime)sqlDataReader["InDate"];
                    this.cbxOutHospitalRoom.SelectedValue = (int)sqlDataReader["OutOfficesNo"];
                    this.dtpOutDate.Value = (DateTime)sqlDataReader["OutDate"];
                    this.txbSituation.Text = sqlDataReader["OtherSitiuation"].ToString();
                }

                photoBytes = sqlDataReader["Picture"] == DBNull.Value ? null : (byte[])sqlDataReader["Picture"];

                sqlDataReader.Close();//读取器自带的关闭函数

                if (photoBytes != null)
                {
                    MemoryStream memoryStream = new MemoryStream(photoBytes);
                    this.pbPatient.Image = Image.FromStream(memoryStream);
                }

            }
            else
            {
                MessageBox.Show("暂无病人！");
                return;
            }

        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "选择病人照片",//标题
                InitialDirectory = GetFolderPath(SpecialFolder.MyPictures),//指定文件夹,使用前加了using static System.Environment; ->问题：图片为空时会报错
                Filter = "图片文件|*.jpg;*.bmp;*.png"//过滤器
            };
            if (openFileDialog.ShowDialog()==DialogResult.OK)//为了判断选择或打开或取出的按钮
            {
                string fileName = openFileDialog.FileName;
                this.pbPatient.Image = Image.FromFile(fileName);//使用前加using system.drawing
            }
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            //更新图片文件所需语句
            MemoryStream memoryStream = new MemoryStream();
            this.pbPatient.Image.Save(memoryStream, ImageFormat.Bmp);
            byte[] photoBytes = new byte[memoryStream.Length];
            memoryStream.Seek(0, SeekOrigin.Begin);//保证从头开始读
            memoryStream.Read(photoBytes, 0, photoBytes.Length);

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);DataBase=DataBase_DoctorWorkStation;Integrated Security=true";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"BEGIN TRAN
	                                   UPDATE tb_Patient 
	                                   SET Name=@Name,Gender=@Gender,Career=@Career,Birthday=@Birthday,Picture=@Picture
	                                   WHERE Name=@PatientName
	                                   UPDATE tb_MedicalRecord
	                                   SET ThisNo=@ThisNo,InHospitalCount=@InHospitalCount,OfficesNo=@OfficesNo,InDate=@InDate,OtherSitiuation=@OtherSitiuation,OutOfficesNo=@OutOfficesNo,OutDate=@OutDate
	                                   WHERE Name=@PatientName
	                                   COMMIT";//后面需要考虑要不要加上病人本次住院ID来用于筛选，暂时先用的都是赵春兰的信息
            sqlCommand.Parameters.AddWithValue("@Name",txbName.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Gender",rdbMale.Checked);
            sqlCommand.Parameters.AddWithValue("@Career",txbCareer.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Birthday",dtpBirthday.Value);
            sqlCommand.Parameters.AddWithValue("@ThisNo",txbInHospitalNo.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@InHospitalCount",Convert.ToInt32(txbInHospitalCount.Text.Trim()));
            sqlCommand.Parameters.AddWithValue("@OfficesNo",(int)cbxInHospitalRoom.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@InDate",dtpInDate.Value);
            sqlCommand.Parameters.AddWithValue("@OtherSitiuation",txbSituation.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@OutOfficesNo",(int)cbxOutHospitalRoom.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@OutDate",dtpInDate.Value);
            //更新图片文件
            sqlCommand.Parameters.AddWithValue("@Picture", photoBytes);

            sqlCommand.Parameters.AddWithValue("@PatientName", Patient.Name);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();//执行并返回结果
            sqlConnection.Close();
            //MessageBox.Show($"更新{rowAffected}行。");
            MessageBox.Show($"更新成功。");

        }

        private void frm_Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_FirstAge frm_FirstAge = new frm_FirstAge();
            frm_FirstAge.Show();
            frm_Login frm_Login = new frm_Login();
            frm_Login.Visible = false;
        }
    }
}
