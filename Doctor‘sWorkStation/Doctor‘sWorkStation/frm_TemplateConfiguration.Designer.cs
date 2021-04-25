namespace Doctor_sWorkStation
{
    partial class frm_TemplateConfiguration
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
            this.dgvTemplate = new System.Windows.Forms.DataGridView();
            this.dgvHadPickedTemplate = new System.Windows.Forms.DataGridView();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHadPickedTemplate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHadPickedTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTemplate
            // 
            this.dgvTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemplate.Location = new System.Drawing.Point(31, 91);
            this.dgvTemplate.Name = "dgvTemplate";
            this.dgvTemplate.RowTemplate.Height = 30;
            this.dgvTemplate.Size = new System.Drawing.Size(240, 330);
            this.dgvTemplate.TabIndex = 0;
            // 
            // dgvHadPickedTemplate
            // 
            this.dgvHadPickedTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHadPickedTemplate.Location = new System.Drawing.Point(369, 91);
            this.dgvHadPickedTemplate.Name = "dgvHadPickedTemplate";
            this.dgvHadPickedTemplate.RowTemplate.Height = 30;
            this.dgvHadPickedTemplate.Size = new System.Drawing.Size(240, 330);
            this.dgvHadPickedTemplate.TabIndex = 1;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(301, 160);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(41, 39);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = ">";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(301, 262);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(41, 37);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "<";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存(S)";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(369, 447);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(C)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "可供配置模板";
            // 
            // lblHadPickedTemplate
            // 
            this.lblHadPickedTemplate.AutoSize = true;
            this.lblHadPickedTemplate.Location = new System.Drawing.Point(426, 44);
            this.lblHadPickedTemplate.Name = "lblHadPickedTemplate";
            this.lblHadPickedTemplate.Size = new System.Drawing.Size(116, 18);
            this.lblHadPickedTemplate.TabIndex = 7;
            this.lblHadPickedTemplate.Text = "已经选用模板";
            // 
            // frm_TemplateConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 516);
            this.Controls.Add(this.lblHadPickedTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.dgvHadPickedTemplate);
            this.Controls.Add(this.dgvTemplate);
            this.Name = "frm_TemplateConfiguration";
            this.Text = "模板配置";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHadPickedTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemplate;
        private System.Windows.Forms.DataGridView dgvHadPickedTemplate;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHadPickedTemplate;
    }
}