﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sWorkStation
{
    public partial class frm_EnterDoctorAdvice : Form
    {
        public frm_EnterDoctorAdvice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
