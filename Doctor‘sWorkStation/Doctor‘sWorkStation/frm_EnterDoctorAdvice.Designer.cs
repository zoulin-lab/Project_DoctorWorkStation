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
            this.components = new System.ComponentModel.Container();
            this.lblBedNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAgo = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.gpbLongOrShort = new System.Windows.Forms.GroupBox();
            this.rbnShort = new System.Windows.Forms.RadioButton();
            this.rbnLong = new System.Windows.Forms.RadioButton();
            this.rbnAll = new System.Windows.Forms.RadioButton();
            this.gpbShowLimits = new System.Windows.Forms.GroupBox();
            this.rbnAllShow = new System.Windows.Forms.RadioButton();
            this.rbnRecord = new System.Windows.Forms.RadioButton();
            this.rbnHadDo = new System.Windows.Forms.RadioButton();
            this.dgvDoctorAdvice = new System.Windows.Forms.DataGridView();
            this.dgvDoctorAdvice2 = new System.Windows.Forms.DataGridView();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbLongOrShort.SuspendLayout();
            this.gpbShowLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAdvice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAdvice2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBedNo
            // 
            this.lblBedNo.AutoSize = true;
            this.lblBedNo.Location = new System.Drawing.Point(827, 35);
            this.lblBedNo.Name = "lblBedNo";
            this.lblBedNo.Size = new System.Drawing.Size(44, 18);
            this.lblBedNo.TabIndex = 0;
            this.lblBedNo.Text = "床号";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(193, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(366, 35);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(44, 18);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "性别";
            // 
            // lblAgo
            // 
            this.lblAgo.AutoSize = true;
            this.lblAgo.Location = new System.Drawing.Point(535, 35);
            this.lblAgo.Name = "lblAgo";
            this.lblAgo.Size = new System.Drawing.Size(44, 18);
            this.lblAgo.TabIndex = 3;
            this.lblAgo.Text = "年龄";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(32, 35);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(62, 18);
            this.lblPatientID.TabIndex = 4;
            this.lblPatientID.Text = "病人ID";
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
            this.rbnShort.Click += new System.EventHandler(this.rbnShort_Click);
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
            this.rbnLong.Click += new System.EventHandler(this.rbnLong_Click);
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
            this.rbnAll.Click += new System.EventHandler(this.rbnAll_Click);
            // 
            // gpbShowLimits
            // 
            this.gpbShowLimits.Controls.Add(this.rbnAllShow);
            this.gpbShowLimits.Controls.Add(this.rbnRecord);
            this.gpbShowLimits.Controls.Add(this.rbnHadDo);
            this.gpbShowLimits.Location = new System.Drawing.Point(694, 78);
            this.gpbShowLimits.Name = "gpbShowLimits";
            this.gpbShowLimits.Size = new System.Drawing.Size(334, 69);
            this.gpbShowLimits.TabIndex = 6;
            this.gpbShowLimits.TabStop = false;
            this.gpbShowLimits.Text = "显示范围";
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
            this.rbnAllShow.Click += new System.EventHandler(this.rbnAllShow_Click);
            // 
            // rbnRecord
            // 
            this.rbnRecord.AutoSize = true;
            this.rbnRecord.Location = new System.Drawing.Point(245, 28);
            this.rbnRecord.Name = "rbnRecord";
            this.rbnRecord.Size = new System.Drawing.Size(87, 22);
            this.rbnRecord.TabIndex = 2;
            this.rbnRecord.TabStop = true;
            this.rbnRecord.Text = "已完成";
            this.rbnRecord.UseVisualStyleBackColor = true;
            this.rbnRecord.Click += new System.EventHandler(this.rbnRecord_Click);
            // 
            // rbnHadDo
            // 
            this.rbnHadDo.AutoSize = true;
            this.rbnHadDo.Location = new System.Drawing.Point(136, 28);
            this.rbnHadDo.Name = "rbnHadDo";
            this.rbnHadDo.Size = new System.Drawing.Size(87, 22);
            this.rbnHadDo.TabIndex = 1;
            this.rbnHadDo.TabStop = true;
            this.rbnHadDo.Text = "未执行";
            this.rbnHadDo.UseVisualStyleBackColor = true;
            this.rbnHadDo.Click += new System.EventHandler(this.rbnHadDo_Click);
            // 
            // dgvDoctorAdvice
            // 
            this.dgvDoctorAdvice.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDoctorAdvice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorAdvice.Location = new System.Drawing.Point(19, 180);
            this.dgvDoctorAdvice.Name = "dgvDoctorAdvice";
            this.dgvDoctorAdvice.RowTemplate.Height = 30;
            this.dgvDoctorAdvice.Size = new System.Drawing.Size(1009, 217);
            this.dgvDoctorAdvice.TabIndex = 7;
            // 
            // dgvDoctorAdvice2
            // 
            this.dgvDoctorAdvice2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDoctorAdvice2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorAdvice2.ContextMenuStrip = this.cmsMenu;
            this.dgvDoctorAdvice2.Location = new System.Drawing.Point(21, 421);
            this.dgvDoctorAdvice2.Name = "dgvDoctorAdvice2";
            this.dgvDoctorAdvice2.RowTemplate.Height = 30;
            this.dgvDoctorAdvice2.Size = new System.Drawing.Size(1007, 170);
            this.dgvDoctorAdvice2.TabIndex = 8;
            // 
            // cmsMenu
            // 
            this.cmsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.ShowImageMargin = false;
            this.cmsMenu.Size = new System.Drawing.Size(36, 4);
            this.cmsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenu_Opening);
            this.cmsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMenu_ItemClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 597);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存(T)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(356, 597);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 31);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "新增(A)";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(652, 597);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除(D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(934, 597);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭(C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "已有医嘱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "新开医嘱";
            // 
            // frm_EnterDoctorAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 657);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
    }
}