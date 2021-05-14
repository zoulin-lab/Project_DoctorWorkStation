namespace Doctor_sWorkStation
{
    partial class frm_PatientListTwo
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
            this.tvPatient = new System.Windows.Forms.TreeView();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // tvPatient
            // 
            this.tvPatient.Location = new System.Drawing.Point(33, 29);
            this.tvPatient.Name = "tvPatient";
            this.tvPatient.Size = new System.Drawing.Size(206, 395);
            this.tvPatient.TabIndex = 0;
            this.tvPatient.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPatient_AfterSelect);
            // 
            // dgvPatient
            // 
            this.dgvPatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(274, 29);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.RowTemplate.Height = 30;
            this.dgvPatient.Size = new System.Drawing.Size(588, 395);
            this.dgvPatient.TabIndex = 1;
            // 
            // frm_PatientListTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.tvPatient);
            this.Name = "frm_PatientListTwo";
            this.Text = "所有病人列表";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvPatient;
        private System.Windows.Forms.DataGridView dgvPatient;
    }
}