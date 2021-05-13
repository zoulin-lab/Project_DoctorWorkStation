namespace Doctor_sWorkStation
{
    partial class frm_MedicinesInquire
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEName = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbFuntion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbUsage = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbTaboo = new System.Windows.Forms.TextBox();
            this.palMedicinesInfo = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.palMedicinesInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "按F9输入药品名称";
            // 
            // txbName
            // 
            this.txbName.ForeColor = System.Drawing.Color.Black;
            this.txbName.Location = new System.Drawing.Point(202, 26);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(246, 28);
            this.txbName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(480, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEName);
            this.groupBox1.Controls.Add(this.lblCName);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "【药品名称】";
            // 
            // lblEName
            // 
            this.lblEName.AutoSize = true;
            this.lblEName.Location = new System.Drawing.Point(12, 50);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(62, 18);
            this.lblEName.TabIndex = 1;
            this.lblEName.Text = "label3";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(12, 28);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(62, 18);
            this.lblCName.TabIndex = 0;
            this.lblCName.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbFuntion);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(14, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "【药理作用】";
            // 
            // txbFuntion
            // 
            this.txbFuntion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbFuntion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFuntion.Location = new System.Drawing.Point(7, 27);
            this.txbFuntion.Multiline = true;
            this.txbFuntion.Name = "txbFuntion";
            this.txbFuntion.Size = new System.Drawing.Size(790, 58);
            this.txbFuntion.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbUsage);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(14, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 98);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "【用法】";
            // 
            // txbUsage
            // 
            this.txbUsage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbUsage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsage.Location = new System.Drawing.Point(6, 27);
            this.txbUsage.Multiline = true;
            this.txbUsage.Name = "txbUsage";
            this.txbUsage.Size = new System.Drawing.Size(790, 58);
            this.txbUsage.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbTaboo);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(14, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(803, 106);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "【禁忌】";
            // 
            // txbTaboo
            // 
            this.txbTaboo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbTaboo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTaboo.Location = new System.Drawing.Point(6, 27);
            this.txbTaboo.Multiline = true;
            this.txbTaboo.Name = "txbTaboo";
            this.txbTaboo.Size = new System.Drawing.Size(791, 73);
            this.txbTaboo.TabIndex = 1;
            // 
            // palMedicinesInfo
            // 
            this.palMedicinesInfo.Controls.Add(this.groupBox1);
            this.palMedicinesInfo.Controls.Add(this.groupBox4);
            this.palMedicinesInfo.Controls.Add(this.groupBox2);
            this.palMedicinesInfo.Controls.Add(this.groupBox3);
            this.palMedicinesInfo.Location = new System.Drawing.Point(12, 65);
            this.palMedicinesInfo.Name = "palMedicinesInfo";
            this.palMedicinesInfo.Size = new System.Drawing.Size(831, 444);
            this.palMedicinesInfo.TabIndex = 7;
            // 
            // frm_MedicinesInquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.palMedicinesInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Name = "frm_MedicinesInquire";
            this.Text = "药品信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.palMedicinesInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEName;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel palMedicinesInfo;
        private System.Windows.Forms.TextBox txbFuntion;
        private System.Windows.Forms.TextBox txbUsage;
        private System.Windows.Forms.TextBox txbTaboo;
    }
}