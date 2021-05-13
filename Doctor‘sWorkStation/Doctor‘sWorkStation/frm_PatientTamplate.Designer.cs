namespace Doctor_sWorkStation
{
    partial class frm_PatientTamplate
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
            this.rtbTamplate = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTamplate
            // 
            this.rtbTamplate.Location = new System.Drawing.Point(30, 40);
            this.rtbTamplate.Name = "rtbTamplate";
            this.rtbTamplate.Size = new System.Drawing.Size(922, 508);
            this.rtbTamplate.TabIndex = 0;
            this.rtbTamplate.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(877, 563);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frm_PatientTamplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 612);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbTamplate);
            this.Name = "frm_PatientTamplate";
            this.Text = "病历模板详细内容";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTamplate;
        private System.Windows.Forms.Button btnSave;
    }
}