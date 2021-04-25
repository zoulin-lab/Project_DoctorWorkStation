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
using Microsoft.Office;
using MSWord = Microsoft.Office.Interop.Word;

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
            frm_PatientTamplate frm_PatientTamplate = new frm_PatientTamplate();
            frm_PatientTamplate.Show();
        }
        
    }
}
