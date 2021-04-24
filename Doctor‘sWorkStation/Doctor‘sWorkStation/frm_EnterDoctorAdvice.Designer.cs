namespace Doctor_sWorkStation
{
    partial class frm_EnterDoctorAdvice
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
            this.lblBedNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAgo = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.gpbLongOrShort = new System.Windows.Forms.GroupBox();
            this.gpbShowLimits = new System.Windows.Forms.GroupBox();
            this.rbnAll = new System.Windows.Forms.RadioButton();
            this.rbnLong = new System.Windows.Forms.RadioButton();
            this.rbnShort = new System.Windows.Forms.RadioButton();
            this.rbnHadDo = new System.Windows.Forms.RadioButton();
            this.rbnRecord = new System.Windows.Forms.RadioButton();
            this.rbnAllShow = new System.Windows.Forms.RadioButton();
            this.dgvDoctorAdvice = new System.Windows.Forms.DataGridView();
            this.dgvDoctorAdvice2 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gpbLongOrShort.SuspendLayout();
            this.gpbShowLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAdvice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAdvice2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBedNo
            // 
            this.lblBedNo.AutoSize = true;
            this.lblBedNo.Location = new System.Drawing.Point(32, 35);
            this.lblBedNo.Name = "lblBedNo";
            this.lblBedNo.Size = new System.Drawing.Size(62, 18);
            this.lblBedNo.TabIndex = 0;
            this.lblBedNo.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(193, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label2";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(366, 35);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 18);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "label3";
            // 
            // lblAgo
            // 
            this.lblAgo.AutoSize = true;
            this.lblAgo.Location = new System.Drawing.Point(535, 35);
            this.lblAgo.Name = "lblAgo";
            this.lblAgo.Size = new System.Drawing.Size(62, 18);
            this.lblAgo.TabIndex = 3;
            this.lblAgo.Text = "label4";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(714, 35);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(62, 18);
            this.lblPatientID.TabIndex = 4;
            this.lblPatientID.Text = "label5";
            // 
            // gpbLongOrShort
            // 
            this.gpbLongOrShort.Controls.Add(this.rbnShort);
            this.gpbLongOrShort.Controls.Add(this.rbnLong);
            this.gpbLongOrShort.Controls.Add(this.rbnAll);
            this.gpbLongOrShort.Location = new System.Drawing.Point(21, 78);
            this.gpbLongOrShort.Name = "gpbLongOrShort";
            this.gpbLongOrShort.Size = new System.Drawing.Size(324, 69);
            this.gpbLongOrShort.TabIndex = 5;
            this.gpbLongOrShort.TabStop = false;
            this.gpbLongOrShort.Text = "长期/临时";
            // 
            // gpbShowLimits
            // 
            this.gpbShowLimits.Controls.Add(this.rbnAllShow);
            this.gpbShowLimits.Controls.Add(this.rbnRecord);
            this.gpbShowLimits.Controls.Add(this.rbnHadDo);
            this.gpbShowLimits.Location = new System.Drawing.Point(556, 78);
            this.gpbShowLimits.Name = "gpbShowLimits";
            this.gpbShowLimits.Size = new System.Drawing.Size(334, 69);
            this.gpbShowLimits.TabIndex = 6;
            this.gpbShowLimits.TabStop = false;
            this.gpbShowLimits.Text = "显示范围";
            // 
            // rbnAll
            // 
            this.rbnAll.AutoSize = true;
            this.rbnAll.Location = new System.Drawing.Point(14, 28);
            this.rbnAll.Name = "rbnAll";
            this.rbnAll.Size = new System.Drawing.Size(69, 22);
            this.rbnAll.TabIndex = 0;
            this.rbnAll.TabStop = true;
            this.rbnAll.Text = "全部";
            this.rbnAll.UseVisualStyleBackColor = true;
            // 
            // rbnLong
            // 
            this.rbnLong.AutoSize = true;
            this.rbnLong.Location = new System.Drawing.Point(122, 28);
            this.rbnLong.Name = "rbnLong";
            this.rbnLong.Size = new System.Drawing.Size(69, 22);
            this.rbnLong.TabIndex = 1;
            this.rbnLong.TabStop = true;
            this.rbnLong.Text = "长期";
            this.rbnLong.UseVisualStyleBackColor = true;
            // 
            // rbnShort
            // 
            this.rbnShort.AutoSize = true;
            this.rbnShort.Location = new System.Drawing.Point(231, 28);
            this.rbnShort.Name = "rbnShort";
            this.rbnShort.Size = new System.Drawing.Size(69, 22);
            this.rbnShort.TabIndex = 2;
            this.rbnShort.TabStop = true;
            this.rbnShort.Text = "短期";
            this.rbnShort.UseVisualStyleBackColor = true;
            // 
            // rbnHadDo
            // 
            this.rbnHadDo.AutoSize = true;
            this.rbnHadDo.Location = new System.Drawing.Point(136, 28);
            this.rbnHadDo.Name = "rbnHadDo";
            this.rbnHadDo.Size = new System.Drawing.Size(87, 22);
            this.rbnHadDo.TabIndex = 1;
            this.rbnHadDo.TabStop = true;
            this.rbnHadDo.Text = "已执行";
            this.rbnHadDo.UseVisualStyleBackColor = true;
            // 
            // rbnRecord
            // 
            this.rbnRecord.AutoSize = true;
            this.rbnRecord.Location = new System.Drawing.Point(245, 28);
            this.rbnRecord.Name = "rbnRecord";
            this.rbnRecord.Size = new System.Drawing.Size(87, 22);
            this.rbnRecord.TabIndex = 2;
            this.rbnRecord.TabStop = true;
            this.rbnRecord.Text = "医嘱本";
            this.rbnRecord.UseVisualStyleBackColor = true;
            // 
            // rbnAllShow
            // 
            this.rbnAllShow.AutoSize = true;
            this.rbnAllShow.Location = new System.Drawing.Point(15, 28);
            this.rbnAllShow.Name = "rbnAllShow";
            this.rbnAllShow.Size = new System.Drawing.Size(87, 22);
            this.rbnAllShow.TabIndex = 3;
            this.rbnAllShow.TabStop = true;
            this.rbnAllShow.Text = "都显示";
            this.rbnAllShow.UseVisualStyleBackColor = true;
            // 
            // dgvDoctorAdvice
            // 
            this.dgvDoctorAdvice.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoctorAdvice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorAdvice.Location = new System.Drawing.Point(21, 170);
            this.dgvDoctorAdvice.Name = "dgvDoctorAdvice";
            this.dgvDoctorAdvice.RowTemplate.Height = 30;
            this.dgvDoctorAdvice.Size = new System.Drawing.Size(869, 150);
            this.dgvDoctorAdvice.TabIndex = 7;
            // 
            // dgvDoctorAdvice2
            // 
            this.dgvDoctorAdvice2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoctorAdvice2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorAdvice2.Location = new System.Drawing.Point(21, 326);
            this.dgvDoctorAdvice2.Name = "dgvDoctorAdvice2";
            this.dgvDoctorAdvice2.RowTemplate.Height = 30;
            this.dgvDoctorAdvice2.Size = new System.Drawing.Size(869, 150);
            this.dgvDoctorAdvice2.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 495);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存(T)";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(271, 495);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 31);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "新增(A)";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(556, 495);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除(D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(796, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭(C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm_EnterDoctorAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDoctorAdvice2);
            this.Controls.Add(this.dgvDoctorAdvice);
            this.Controls.Add(this.gpbShowLimits);
            this.Controls.Add(this.gpbLongOrShort);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblAgo);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBedNo);
            this.Name = "frm_EnterDoctorAdvice";
            this.Text = "医嘱录入";
            this.gpbLongOrShort.ResumeLayout(false);
            this.gpbLongOrShort.PerformLayout();
            this.gpbShowLimits.ResumeLayout(false);
            this.gpbShowLimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAdvice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAdvice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBedNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAgo;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.GroupBox gpbLongOrShort;
        private System.Windows.Forms.RadioButton rbnShort;
        private System.Windows.Forms.RadioButton rbnLong;
        private System.Windows.Forms.RadioButton rbnAll;
        private System.Windows.Forms.GroupBox gpbShowLimits;
        private System.Windows.Forms.RadioButton rbnAllShow;
        private System.Windows.Forms.RadioButton rbnRecord;
        private System.Windows.Forms.RadioButton rbnHadDo;
        private System.Windows.Forms.DataGridView dgvDoctorAdvice;
        private System.Windows.Forms.DataGridView dgvDoctorAdvice2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}