namespace Doctor_sWorkStation
{
    partial class frm_DischargeNotice
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInfo2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(32, 41);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 30;
            this.dgvInfo.Size = new System.Drawing.Size(981, 227);
            this.dgvInfo.TabIndex = 0;
            // 
            // btnDischarge
            // 
            this.btnDischarge.Location = new System.Drawing.Point(938, 573);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(75, 38);
            this.btnDischarge.TabIndex = 1;
            this.btnDischarge.Text = "出院";
            this.btnDischarge.UseVisualStyleBackColor = true;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "已缴费项目详细信息";
            // 
            // dgvInfo2
            // 
            this.dgvInfo2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInfo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo2.Location = new System.Drawing.Point(32, 328);
            this.dgvInfo2.Name = "dgvInfo2";
            this.dgvInfo2.RowTemplate.Height = 30;
            this.dgvInfo2.Size = new System.Drawing.Size(981, 227);
            this.dgvInfo2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "未缴费项目详细信息";
            // 
            // frm_DischargeNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInfo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDischarge);
            this.Controls.Add(this.dgvInfo);
            this.Name = "frm_DischargeNotice";
            this.Text = "出院通知";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInfo2;
        private System.Windows.Forms.Label label2;
    }
}