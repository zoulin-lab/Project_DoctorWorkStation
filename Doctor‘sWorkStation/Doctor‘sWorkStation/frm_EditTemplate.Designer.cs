namespace Doctor_sWorkStation
{
    partial class frm_EditTemplate
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTemplateTitle = new System.Windows.Forms.TextBox();
            this.cbxTemplateCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(157, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 32);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(254, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(346, 251);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(65, 32);
            this.btnCanel.TabIndex = 2;
            this.btnCanel.Text = "放弃";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "模板主题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "模板类型";
            // 
            // txbTemplateTitle
            // 
            this.txbTemplateTitle.Location = new System.Drawing.Point(157, 92);
            this.txbTemplateTitle.Name = "txbTemplateTitle";
            this.txbTemplateTitle.Size = new System.Drawing.Size(254, 28);
            this.txbTemplateTitle.TabIndex = 6;
            // 
            // cbxTemplateCategory
            // 
            this.cbxTemplateCategory.FormattingEnabled = true;
            this.cbxTemplateCategory.Items.AddRange(new object[] {
            "-请选择-",
            "个人",
            "公用",
            "科室"});
            this.cbxTemplateCategory.Location = new System.Drawing.Point(157, 166);
            this.cbxTemplateCategory.Name = "cbxTemplateCategory";
            this.cbxTemplateCategory.Size = new System.Drawing.Size(254, 26);
            this.cbxTemplateCategory.TabIndex = 7;
            // 
            // frm_EditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 403);
            this.Controls.Add(this.cbxTemplateCategory);
            this.Controls.Add(this.txbTemplateTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Name = "frm_EditTemplate";
            this.Text = "编辑模板";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_EditTemplate_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTemplateTitle;
        private System.Windows.Forms.ComboBox cbxTemplateCategory;
    }
}