namespace winform大作业
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询删除学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生人数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加班级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询删除班级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加科目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询修改删除科目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.题库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加试题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询修改试题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考试管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.辅助功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示当前系统时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.改变窗体颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.班级管理ToolStripMenuItem,
            this.科目管理ToolStripMenuItem,
            this.题库管理ToolStripMenuItem,
            this.考试管理ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.辅助功能ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生ToolStripMenuItem,
            this.查询删除学生ToolStripMenuItem,
            this.学生信息列表ToolStripMenuItem,
            this.学生人数ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 添加学生ToolStripMenuItem
            // 
            this.添加学生ToolStripMenuItem.Name = "添加学生ToolStripMenuItem";
            this.添加学生ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.添加学生ToolStripMenuItem.Text = "添加学生";
            this.添加学生ToolStripMenuItem.Click += new System.EventHandler(this.添加学生ToolStripMenuItem_Click);
            // 
            // 查询删除学生ToolStripMenuItem
            // 
            this.查询删除学生ToolStripMenuItem.Name = "查询删除学生ToolStripMenuItem";
            this.查询删除学生ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.查询删除学生ToolStripMenuItem.Text = "查询/删除学生";
            this.查询删除学生ToolStripMenuItem.Click += new System.EventHandler(this.查询删除学生ToolStripMenuItem_Click);
            // 
            // 学生信息列表ToolStripMenuItem
            // 
            this.学生信息列表ToolStripMenuItem.Name = "学生信息列表ToolStripMenuItem";
            this.学生信息列表ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.学生信息列表ToolStripMenuItem.Text = "学生信息列表";
            this.学生信息列表ToolStripMenuItem.Click += new System.EventHandler(this.学生信息列表ToolStripMenuItem_Click);
            // 
            // 学生人数ToolStripMenuItem
            // 
            this.学生人数ToolStripMenuItem.Name = "学生人数ToolStripMenuItem";
            this.学生人数ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.学生人数ToolStripMenuItem.Text = "学生人数";
            this.学生人数ToolStripMenuItem.Click += new System.EventHandler(this.学生人数ToolStripMenuItem_Click);
            // 
            // 班级管理ToolStripMenuItem
            // 
            this.班级管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加班级ToolStripMenuItem,
            this.查询删除班级ToolStripMenuItem});
            this.班级管理ToolStripMenuItem.Name = "班级管理ToolStripMenuItem";
            this.班级管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.班级管理ToolStripMenuItem.Text = "班级管理";
            // 
            // 添加班级ToolStripMenuItem
            // 
            this.添加班级ToolStripMenuItem.Name = "添加班级ToolStripMenuItem";
            this.添加班级ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.添加班级ToolStripMenuItem.Text = "添加班级";
            this.添加班级ToolStripMenuItem.Click += new System.EventHandler(this.添加班级ToolStripMenuItem_Click);
            // 
            // 查询删除班级ToolStripMenuItem
            // 
            this.查询删除班级ToolStripMenuItem.Name = "查询删除班级ToolStripMenuItem";
            this.查询删除班级ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.查询删除班级ToolStripMenuItem.Text = "查询/修改班级";
            this.查询删除班级ToolStripMenuItem.Click += new System.EventHandler(this.查询删除班级ToolStripMenuItem_Click);
            // 
            // 科目管理ToolStripMenuItem
            // 
            this.科目管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加科目ToolStripMenuItem,
            this.查询修改删除科目ToolStripMenuItem});
            this.科目管理ToolStripMenuItem.Name = "科目管理ToolStripMenuItem";
            this.科目管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.科目管理ToolStripMenuItem.Text = "科目管理";
            // 
            // 添加科目ToolStripMenuItem
            // 
            this.添加科目ToolStripMenuItem.Name = "添加科目ToolStripMenuItem";
            this.添加科目ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.添加科目ToolStripMenuItem.Text = "添加科目";
            this.添加科目ToolStripMenuItem.Click += new System.EventHandler(this.添加科目ToolStripMenuItem_Click);
            // 
            // 查询修改删除科目ToolStripMenuItem
            // 
            this.查询修改删除科目ToolStripMenuItem.Name = "查询修改删除科目ToolStripMenuItem";
            this.查询修改删除科目ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.查询修改删除科目ToolStripMenuItem.Text = "查询/修改/删除科目";
            this.查询修改删除科目ToolStripMenuItem.Click += new System.EventHandler(this.查询修改删除科目ToolStripMenuItem_Click);
            // 
            // 题库管理ToolStripMenuItem
            // 
            this.题库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加试题ToolStripMenuItem,
            this.查询修改试题ToolStripMenuItem});
            this.题库管理ToolStripMenuItem.Name = "题库管理ToolStripMenuItem";
            this.题库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.题库管理ToolStripMenuItem.Text = "题库管理";
            // 
            // 添加试题ToolStripMenuItem
            // 
            this.添加试题ToolStripMenuItem.Name = "添加试题ToolStripMenuItem";
            this.添加试题ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.添加试题ToolStripMenuItem.Text = "添加试题";
            this.添加试题ToolStripMenuItem.Click += new System.EventHandler(this.添加试题ToolStripMenuItem_Click);
            // 
            // 查询修改试题ToolStripMenuItem
            // 
            this.查询修改试题ToolStripMenuItem.Name = "查询修改试题ToolStripMenuItem";
            this.查询修改试题ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.查询修改试题ToolStripMenuItem.Text = "查询/修改试题";
            this.查询修改试题ToolStripMenuItem.Click += new System.EventHandler(this.查询修改试题ToolStripMenuItem_Click);
            // 
            // 考试管理ToolStripMenuItem
            // 
            this.考试管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩浏览ToolStripMenuItem});
            this.考试管理ToolStripMenuItem.Name = "考试管理ToolStripMenuItem";
            this.考试管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.考试管理ToolStripMenuItem.Text = "考试管理";
            // 
            // 成绩浏览ToolStripMenuItem
            // 
            this.成绩浏览ToolStripMenuItem.Name = "成绩浏览ToolStripMenuItem";
            this.成绩浏览ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.成绩浏览ToolStripMenuItem.Text = "成绩浏览";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 辅助功能ToolStripMenuItem
            // 
            this.辅助功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示当前系统时间ToolStripMenuItem,
            this.改变窗体颜色ToolStripMenuItem});
            this.辅助功能ToolStripMenuItem.Name = "辅助功能ToolStripMenuItem";
            this.辅助功能ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.辅助功能ToolStripMenuItem.Text = "辅助功能";
            this.辅助功能ToolStripMenuItem.Click += new System.EventHandler(this.辅助功能ToolStripMenuItem_Click);
            // 
            // 显示当前系统时间ToolStripMenuItem
            // 
            this.显示当前系统时间ToolStripMenuItem.Name = "显示当前系统时间ToolStripMenuItem";
            this.显示当前系统时间ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.显示当前系统时间ToolStripMenuItem.Text = "显示当前系统时间";
            this.显示当前系统时间ToolStripMenuItem.Click += new System.EventHandler(this.显示当前系统时间ToolStripMenuItem_Click);
            // 
            // 改变窗体颜色ToolStripMenuItem
            // 
            this.改变窗体颜色ToolStripMenuItem.Name = "改变窗体颜色ToolStripMenuItem";
            this.改变窗体颜色ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.改变窗体颜色ToolStripMenuItem.Text = "改变窗体颜色";
            this.改变窗体颜色ToolStripMenuItem.Click += new System.EventHandler(this.改变窗体颜色ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolStripButton7,
            this.toolStripSeparator5,
            this.toolStripButton8,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "新增学员";
            this.toolStripButton1.Click += new System.EventHandler(this.添加学生ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "查询以及修改学员信息";
            this.toolStripButton2.Click += new System.EventHandler(this.查询删除学生ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "学员列表";
            this.toolStripButton3.Click += new System.EventHandler(this.学生信息列表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "增加试题";
            this.toolStripButton4.Click += new System.EventHandler(this.添加试题ToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "查询以及修改试题";
            this.toolStripButton5.Click += new System.EventHandler(this.查询修改试题ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "试题信息列表";
            this.toolStripButton7.Click += new System.EventHandler(this.查询修改试题ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "退出";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "教师窗口";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.Text = "Teacher_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherForm_FormClosing);
            this.Load += new System.EventHandler(this.Teacher_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询删除学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生人数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加班级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询删除班级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加科目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询修改删除科目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 题库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加试题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询修改试题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 辅助功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 显示当前系统时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 改变窗体颜色ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}