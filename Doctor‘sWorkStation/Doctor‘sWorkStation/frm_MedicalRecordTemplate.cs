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
    public partial class frm_MedicalRecordTemplate : Form
    {
        public frm_MedicalRecordTemplate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\杂物\19信管3190707031邹林.DOCX");
        }
    }
}
