namespace Doctor_sWorkStation
{
    partial class frm_MedicalRecordWrite
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
            this.txbMedicalRecordTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbxTemplate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbMedicalRecordTitle
            // 
            this.txbMedicalRecordTitle.Location = new System.Drawing.Point(160, 112);
            this.txbMedicalRecordTitle.Name = "txbMedicalRecordTitle";
            this.txbMedicalRecordTitle.Size = new System.Drawing.Size(254, 28);
            this.txbMedicalRecordTitle.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "模板";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "病历主题";
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(349, 271);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(65, 32);
            this.btnCanel.TabIndex = 9;
            this.btnCanel.Text = "放弃";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(257, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(160, 271);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 32);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbxTemplate
            // 
            this.cbxTemplate.FormattingEnabled = true;
            this.cbxTemplate.Location = new System.Drawing.Point(160, 186);
            this.cbxTemplate.Name = "cbxTemplate";
            this.cbxTemplate.Size = new System.Drawing.Size(254, 26);
            this.cbxTemplate.TabIndex = 13;
            // 
            // frm_MedicalRecordWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 403);
            this.Controls.Add(this.cbxTemplate);
            this.Controls.Add(this.txbMedicalRecordTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Name = "frm_MedicalRecordWrite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbMedicalRecordTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbxTemplate;
    }
}