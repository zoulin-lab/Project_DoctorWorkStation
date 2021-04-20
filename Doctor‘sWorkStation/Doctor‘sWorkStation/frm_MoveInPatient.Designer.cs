namespace Doctor_sWorkStation
{
    partial class frm_MoveInPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMoveInPatient = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.rbnStudy = new System.Windows.Forms.RadioButton();
            this.rbnInHospital = new System.Windows.Forms.RadioButton();
            this.gpCategory = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoveInPatient)).BeginInit();
            this.gpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMoveInPatient
            // 
            this.dgvMoveInPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgvMoveInPatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoveInPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMoveInPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoveInPatient.ColumnHeadersVisible = false;
            this.dgvMoveInPatient.Location = new System.Drawing.Point(12, 14);
            this.dgvMoveInPatient.Name = "dgvMoveInPatient";
            this.dgvMoveInPatient.RowHeadersVisible = false;
            this.dgvMoveInPatient.RowTemplate.Height = 30;
            this.dgvMoveInPatient.Size = new System.Drawing.Size(219, 303);
            this.dgvMoveInPatient.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(300, 149);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 30);
            this.btnSure.TabIndex = 8;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // rbnStudy
            // 
            this.rbnStudy.AutoSize = true;
            this.rbnStudy.Location = new System.Drawing.Point(25, 27);
            this.rbnStudy.Name = "rbnStudy";
            this.rbnStudy.Size = new System.Drawing.Size(105, 22);
            this.rbnStudy.TabIndex = 10;
            this.rbnStudy.TabStop = true;
            this.rbnStudy.Text = "学习病历";
            this.rbnStudy.UseVisualStyleBackColor = true;
            // 
            // rbnInHospital
            // 
            this.rbnInHospital.AutoSize = true;
            this.rbnInHospital.Checked = true;
            this.rbnInHospital.Location = new System.Drawing.Point(25, 70);
            this.rbnInHospital.Name = "rbnInHospital";
            this.rbnInHospital.Size = new System.Drawing.Size(105, 22);
            this.rbnInHospital.TabIndex = 11;
            this.rbnInHospital.TabStop = true;
            this.rbnInHospital.Text = "在院病历";
            this.rbnInHospital.UseVisualStyleBackColor = true;
            // 
            // gpCategory
            // 
            this.gpCategory.Controls.Add(this.rbnStudy);
            this.gpCategory.Controls.Add(this.rbnInHospital);
            this.gpCategory.Location = new System.Drawing.Point(261, 14);
            this.gpCategory.Name = "gpCategory";
            this.gpCategory.Size = new System.Drawing.Size(157, 109);
            this.gpCategory.TabIndex = 12;
            this.gpCategory.TabStop = false;
            // 
            // frm_MoveInPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 329);
            this.Controls.Add(this.gpCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.dgvMoveInPatient);
            this.Name = "frm_MoveInPatient";
            this.Text = "移入病人";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_MoveInPatient_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoveInPatient)).EndInit();
            this.gpCategory.ResumeLayout(false);
            this.gpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoveInPatient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.RadioButton rbnStudy;
        private System.Windows.Forms.RadioButton rbnInHospital;
        private System.Windows.Forms.GroupBox gpCategory;
    }
}