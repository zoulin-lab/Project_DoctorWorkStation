namespace Doctor_sWorkStation
{
    partial class frm_WaitBedPatient
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
            this.dgvWaitBedPatient = new System.Windows.Forms.DataGridView();
            this.lblBed = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitBedPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWaitBedPatient
            // 
            this.dgvWaitBedPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaitBedPatient.Location = new System.Drawing.Point(25, 33);
            this.dgvWaitBedPatient.Name = "dgvWaitBedPatient";
            this.dgvWaitBedPatient.RowTemplate.Height = 30;
            this.dgvWaitBedPatient.Size = new System.Drawing.Size(620, 283);
            this.dgvWaitBedPatient.TabIndex = 0;
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(25, 334);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(62, 18);
            this.lblBed.TabIndex = 1;
            this.lblBed.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(558, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frm_WaitBedPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 389);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.dgvWaitBedPatient);
            this.Name = "frm_WaitBedPatient";
            this.Text = "等床病人";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitBedPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWaitBedPatient;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Button btnSave;
    }
}