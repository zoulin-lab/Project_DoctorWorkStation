namespace Doctor_sWorkStation
{
    partial class frm_FirstAge
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbPatient = new System.Windows.Forms.ListBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.病历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提交ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排列图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.医生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空白化验单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.制式化验单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病案检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学习病历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.套餐医嘱定义ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.药品字典ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病历模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出院通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.等床病人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择摆药药局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主题帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msTools = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lbObject = new System.Windows.Forms.ListBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.msTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbPatient
            // 
            this.lbPatient.FormattingEnabled = true;
            this.lbPatient.ItemHeight = 18;
            this.lbPatient.Location = new System.Drawing.Point(12, 75);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Size = new System.Drawing.Size(176, 526);
            this.lbPatient.TabIndex = 0;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(81, 43);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(98, 18);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "的病人列表";
            // 
            // 病历ToolStripMenuItem
            // 
            this.病历ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.移入ToolStripMenuItem,
            this.移出ToolStripMenuItem,
            this.提交ToolStripMenuItem,
            this.属性ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.病历ToolStripMenuItem.Name = "病历ToolStripMenuItem";
            this.病历ToolStripMenuItem.Size = new System.Drawing.Size(112, 28);
            this.病历ToolStripMenuItem.Text = "病历（M）";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 移入ToolStripMenuItem
            // 
            this.移入ToolStripMenuItem.Name = "移入ToolStripMenuItem";
            this.移入ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.移入ToolStripMenuItem.Text = "移入";
            this.移入ToolStripMenuItem.Click += new System.EventHandler(this.移入ToolStripMenuItem_Click);
            // 
            // 移出ToolStripMenuItem
            // 
            this.移出ToolStripMenuItem.Name = "移出ToolStripMenuItem";
            this.移出ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.移出ToolStripMenuItem.Text = "移出";
            this.移出ToolStripMenuItem.Click += new System.EventHandler(this.移出ToolStripMenuItem_Click);
            // 
            // 提交ToolStripMenuItem
            // 
            this.提交ToolStripMenuItem.Name = "提交ToolStripMenuItem";
            this.提交ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.提交ToolStripMenuItem.Text = "提交";
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.属性ToolStripMenuItem.Text = "属性";
            this.属性ToolStripMenuItem.Click += new System.EventHandler(this.属性ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.列表ToolStripMenuItem,
            this.排列图标ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.选项ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(106, 28);
            this.查看ToolStripMenuItem.Text = "查看（V）";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.大图标ToolStripMenuItem.Text = "大图标";
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.小图标ToolStripMenuItem.Text = "小图标";
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.列表ToolStripMenuItem.Text = "列表";
            // 
            // 排列图标ToolStripMenuItem
            // 
            this.排列图标ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主题ToolStripMenuItem,
            this.医生ToolStripMenuItem,
            this.时间ToolStripMenuItem,
            this.状态ToolStripMenuItem});
            this.排列图标ToolStripMenuItem.Name = "排列图标ToolStripMenuItem";
            this.排列图标ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.排列图标ToolStripMenuItem.Text = "排列图标";
            // 
            // 主题ToolStripMenuItem
            // 
            this.主题ToolStripMenuItem.Name = "主题ToolStripMenuItem";
            this.主题ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.主题ToolStripMenuItem.Text = "主题";
            // 
            // 医生ToolStripMenuItem
            // 
            this.医生ToolStripMenuItem.Name = "医生ToolStripMenuItem";
            this.医生ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.医生ToolStripMenuItem.Text = "医生";
            // 
            // 时间ToolStripMenuItem
            // 
            this.时间ToolStripMenuItem.Name = "时间ToolStripMenuItem";
            this.时间ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.时间ToolStripMenuItem.Text = "时间";
            // 
            // 状态ToolStripMenuItem
            // 
            this.状态ToolStripMenuItem.Name = "状态ToolStripMenuItem";
            this.状态ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.状态ToolStripMenuItem.Text = "状态";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.空白化验单ToolStripMenuItem,
            this.制式化验单ToolStripMenuItem,
            this.病案检索ToolStripMenuItem,
            this.学习病历ToolStripMenuItem,
            this.套餐医嘱定义ToolStripMenuItem,
            this.药品字典ToolStripMenuItem,
            this.病历模板ToolStripMenuItem,
            this.选择模板ToolStripMenuItem,
            this.出院通知ToolStripMenuItem,
            this.等床病人ToolStripMenuItem,
            this.选择摆药药局ToolStripMenuItem,
            this.修改口令ToolStripMenuItem,
            this.参数设置ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(104, 28);
            this.工具ToolStripMenuItem.Text = "工具（T）";
            // 
            // 空白化验单ToolStripMenuItem
            // 
            this.空白化验单ToolStripMenuItem.Name = "空白化验单ToolStripMenuItem";
            this.空白化验单ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.空白化验单ToolStripMenuItem.Text = "空白化验单";
            // 
            // 制式化验单ToolStripMenuItem
            // 
            this.制式化验单ToolStripMenuItem.Name = "制式化验单ToolStripMenuItem";
            this.制式化验单ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.制式化验单ToolStripMenuItem.Text = "制式化验单";
            // 
            // 病案检索ToolStripMenuItem
            // 
            this.病案检索ToolStripMenuItem.Name = "病案检索ToolStripMenuItem";
            this.病案检索ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.病案检索ToolStripMenuItem.Text = "病案检索";
            // 
            // 学习病历ToolStripMenuItem
            // 
            this.学习病历ToolStripMenuItem.Name = "学习病历ToolStripMenuItem";
            this.学习病历ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.学习病历ToolStripMenuItem.Text = "学习病历";
            // 
            // 套餐医嘱定义ToolStripMenuItem
            // 
            this.套餐医嘱定义ToolStripMenuItem.Name = "套餐医嘱定义ToolStripMenuItem";
            this.套餐医嘱定义ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.套餐医嘱定义ToolStripMenuItem.Text = "套餐医嘱定义";
            // 
            // 药品字典ToolStripMenuItem
            // 
            this.药品字典ToolStripMenuItem.Name = "药品字典ToolStripMenuItem";
            this.药品字典ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.药品字典ToolStripMenuItem.Text = "药品字典";
            // 
            // 病历模板ToolStripMenuItem
            // 
            this.病历模板ToolStripMenuItem.Name = "病历模板ToolStripMenuItem";
            this.病历模板ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.病历模板ToolStripMenuItem.Text = "病历模板";
            // 
            // 选择模板ToolStripMenuItem
            // 
            this.选择模板ToolStripMenuItem.Name = "选择模板ToolStripMenuItem";
            this.选择模板ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.选择模板ToolStripMenuItem.Text = "选择模板";
            // 
            // 出院通知ToolStripMenuItem
            // 
            this.出院通知ToolStripMenuItem.Name = "出院通知ToolStripMenuItem";
            this.出院通知ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.出院通知ToolStripMenuItem.Text = "出院通知";
            // 
            // 等床病人ToolStripMenuItem
            // 
            this.等床病人ToolStripMenuItem.Name = "等床病人ToolStripMenuItem";
            this.等床病人ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.等床病人ToolStripMenuItem.Text = "等床病人";
            // 
            // 选择摆药药局ToolStripMenuItem
            // 
            this.选择摆药药局ToolStripMenuItem.Name = "选择摆药药局ToolStripMenuItem";
            this.选择摆药药局ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.选择摆药药局ToolStripMenuItem.Text = "选择摆药药局";
            // 
            // 修改口令ToolStripMenuItem
            // 
            this.修改口令ToolStripMenuItem.Name = "修改口令ToolStripMenuItem";
            this.修改口令ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.修改口令ToolStripMenuItem.Text = "修改口令";
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主题帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(108, 28);
            this.帮助HToolStripMenuItem.Text = "帮助（H）";
            // 
            // 主题帮助ToolStripMenuItem
            // 
            this.主题帮助ToolStripMenuItem.Name = "主题帮助ToolStripMenuItem";
            this.主题帮助ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.主题帮助ToolStripMenuItem.Text = "主题帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // msTools
            // 
            this.msTools.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.病历ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.msTools.Location = new System.Drawing.Point(0, 0);
            this.msTools.Name = "msTools";
            this.msTools.Size = new System.Drawing.Size(1100, 32);
            this.msTools.TabIndex = 0;
            this.msTools.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(217, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "主题";
            // 
            // lbObject
            // 
            this.lbObject.FormattingEnabled = true;
            this.lbObject.ItemHeight = 18;
            this.lbObject.Items.AddRange(new object[] {
            "病程",
            "检查",
            "检验",
            "首页",
            "体温",
            "医嘱"});
            this.lbObject.Location = new System.Drawing.Point(220, 75);
            this.lbObject.Name = "lbObject";
            this.lbObject.Size = new System.Drawing.Size(853, 526);
            this.lbObject.TabIndex = 2;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.ForeColor = System.Drawing.Color.Red;
            this.lblDoctor.Location = new System.Drawing.Point(13, 42);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(62, 18);
            this.lblDoctor.TabIndex = 3;
            this.lblDoctor.Text = "Doctor";
            // 
            // frm_FirstAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 627);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lbObject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lbPatient);
            this.Controls.Add(this.msTools);
            this.MainMenuStrip = this.msTools;
            this.Name = "frm_FirstAge";
            this.Text = "首页";
            this.msTools.ResumeLayout(false);
            this.msTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lbPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ToolStripMenuItem 病历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提交ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排列图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 医生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空白化验单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 制式化验单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病案检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学习病历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 套餐医嘱定义ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药品字典ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病历模板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择模板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出院通知ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 等床病人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择摆药药局ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改口令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主题帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbObject;
        private System.Windows.Forms.Label lblDoctor;
    }
}