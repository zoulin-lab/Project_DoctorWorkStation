namespace Doctor_sWorkStation
{
    partial class frm_CostInformation
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
            this.dgvCostInfo1 = new System.Windows.Forms.DataGridView();
            this.dgvCostInfo2 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdvancePayment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostInfo2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCostInfo1
            // 
            this.dgvCostInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostInfo1.Location = new System.Drawing.Point(36, 70);
            this.dgvCostInfo1.Name = "dgvCostInfo1";
            this.dgvCostInfo1.RowTemplate.Height = 30;
            this.dgvCostInfo1.Size = new System.Drawing.Size(291, 399);
            this.dgvCostInfo1.TabIndex = 0;
            // 
            // dgvCostInfo2
            // 
            this.dgvCostInfo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostInfo2.Location = new System.Drawing.Point(455, 70);
            this.dgvCostInfo2.Name = "dgvCostInfo2";
            this.dgvCostInfo2.RowTemplate.Height = 30;
            this.dgvCostInfo2.Size = new System.Drawing.Size(291, 399);
            this.dgvCostInfo2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(653, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdvancePayment
            // 
            this.btnAdvancePayment.Location = new System.Drawing.Point(345, 158);
            this.btnAdvancePayment.Name = "btnAdvancePayment";
            this.btnAdvancePayment.Size = new System.Drawing.Size(93, 37);
            this.btnAdvancePayment.TabIndex = 3;
            this.btnAdvancePayment.Text = "缴费→";
            this.btnAdvancePayment.UseVisualStyleBackColor = true;
            this.btnAdvancePayment.Click += new System.EventHandler(this.btnAdvancePayment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(343, 249);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 37);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "←撤回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(653, 483);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 37);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "所有项目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "已缴费项目";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(455, 485);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 18);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "label3";
            // 
            // frm_CostInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 575);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdvancePayment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvCostInfo2);
            this.Controls.Add(this.dgvCostInfo1);
            this.Name = "frm_CostInformation";
            this.Text = "费用信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostInfo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCostInfo1;
        private System.Windows.Forms.DataGridView dgvCostInfo2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdvancePayment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
    }
}