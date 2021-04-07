namespace Doctor_sWorkStation
{
    partial class frm_Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNo = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbCareer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbInHospitalCount = new System.Windows.Forms.TextBox();
            this.txbInHospitalNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbSituation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.cbxInHospitalRoom = new System.Windows.Forms.ComboBox();
            this.cbxOutHospitalRoom = new System.Windows.Forms.ComboBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.pbPatient = new System.Windows.Forms.PictureBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // tcInfo
            // 
            this.tcInfo.Controls.Add(this.tabPage1);
            this.tcInfo.Controls.Add(this.tabPage2);
            this.tcInfo.Controls.Add(this.tabPage3);
            this.tcInfo.Controls.Add(this.tabPage4);
            this.tcInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcInfo.Location = new System.Drawing.Point(0, 251);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.SelectedIndex = 0;
            this.tcInfo.Size = new System.Drawing.Size(1087, 348);
            this.tcInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1079, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "诊断信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1079, 330);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "中医诊断信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1079, 330);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "手术信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1079, 316);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "其他信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "病人ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // txbNo
            // 
            this.txbNo.Location = new System.Drawing.Point(225, 22);
            this.txbNo.Name = "txbNo";
            this.txbNo.ReadOnly = true;
            this.txbNo.Size = new System.Drawing.Size(100, 28);
            this.txbNo.TabIndex = 3;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(381, 22);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 28);
            this.txbName.TabIndex = 4;
            // 
            // txbCareer
            // 
            this.txbCareer.Location = new System.Drawing.Point(722, 22);
            this.txbCareer.Name = "txbCareer";
            this.txbCareer.Size = new System.Drawing.Size(100, 28);
            this.txbCareer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "身份";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "性别";
            // 
            // txbInHospitalCount
            // 
            this.txbInHospitalCount.Location = new System.Drawing.Point(460, 90);
            this.txbInHospitalCount.Name = "txbInHospitalCount";
            this.txbInHospitalCount.Size = new System.Drawing.Size(106, 28);
            this.txbInHospitalCount.TabIndex = 12;
            // 
            // txbInHospitalNo
            // 
            this.txbInHospitalNo.Location = new System.Drawing.Point(225, 90);
            this.txbInHospitalNo.Name = "txbInHospitalNo";
            this.txbInHospitalNo.Size = new System.Drawing.Size(118, 28);
            this.txbInHospitalNo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "住院次数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "住院号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(828, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "入院日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "入院科室";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(828, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "出生日期";
            // 
            // txbSituation
            // 
            this.txbSituation.Location = new System.Drawing.Point(243, 149);
            this.txbSituation.Name = "txbSituation";
            this.txbSituation.Size = new System.Drawing.Size(323, 28);
            this.txbSituation.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(601, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "出院科室";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "转科情况";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(828, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "出院日期";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(915, 20);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(157, 28);
            this.dtpBirthday.TabIndex = 29;
            // 
            // dtpInDate
            // 
            this.dtpInDate.Location = new System.Drawing.Point(914, 92);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(157, 28);
            this.dtpInDate.TabIndex = 30;
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.Location = new System.Drawing.Point(914, 147);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(157, 28);
            this.dtpOutDate.TabIndex = 31;
            // 
            // cbxInHospitalRoom
            // 
            this.cbxInHospitalRoom.FormattingEnabled = true;
            this.cbxInHospitalRoom.Location = new System.Drawing.Point(695, 90);
            this.cbxInHospitalRoom.Name = "cbxInHospitalRoom";
            this.cbxInHospitalRoom.Size = new System.Drawing.Size(127, 26);
            this.cbxInHospitalRoom.TabIndex = 32;
            // 
            // cbxOutHospitalRoom
            // 
            this.cbxOutHospitalRoom.FormattingEnabled = true;
            this.cbxOutHospitalRoom.Location = new System.Drawing.Point(695, 149);
            this.cbxOutHospitalRoom.Name = "cbxOutHospitalRoom";
            this.cbxOutHospitalRoom.Size = new System.Drawing.Size(127, 26);
            this.cbxOutHospitalRoom.TabIndex = 33;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(547, 26);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(51, 22);
            this.rdbMale.TabIndex = 34;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "男";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(604, 25);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(51, 22);
            this.rdbFemale.TabIndex = 35;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "女";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // pbPatient
            // 
            this.pbPatient.Location = new System.Drawing.Point(13, 12);
            this.pbPatient.Name = "pbPatient";
            this.pbPatient.Size = new System.Drawing.Size(127, 165);
            this.pbPatient.TabIndex = 36;
            this.pbPatient.TabStop = false;
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(13, 201);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(99, 30);
            this.btnPicture.TabIndex = 38;
            this.btnPicture.Text = "选择照片";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(868, 201);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(99, 30);
            this.btnChangeInfo.TabIndex = 39;
            this.btnChangeInfo.Text = "更改信息";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(996, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 40;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pbPatient);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.cbxOutHospitalRoom);
            this.Controls.Add(this.cbxInHospitalRoom);
            this.Controls.Add(this.dtpOutDate);
            this.Controls.Add(this.dtpInDate);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbSituation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbInHospitalCount);
            this.Controls.Add(this.txbInHospitalNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbCareer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcInfo);
            this.Name = "frm_Information";
            this.Text = "首页信息";
            this.tcInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNo;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbCareer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbInHospitalCount;
        private System.Windows.Forms.TextBox txbInHospitalNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbSituation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private System.Windows.Forms.ComboBox cbxInHospitalRoom;
        private System.Windows.Forms.ComboBox cbxOutHospitalRoom;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.PictureBox pbPatient;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button button1;
    }
}