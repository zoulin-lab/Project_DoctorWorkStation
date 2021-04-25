namespace Doctor_sWorkStation
{
    partial class frm_PatientList
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "病人姓名";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(114, 25);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(229, 28);
            this.txbName.TabIndex = 1;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Location = new System.Drawing.Point(31, 108);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowTemplate.Height = 30;
            this.dgvPatientList.Size = new System.Drawing.Size(671, 377);
            this.dgvPatientList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "所有病人列表";
            // 
            // frm_PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPatientList);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Name = "frm_PatientList";
            this.Text = "病人列表";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.Label label2;
    }
}