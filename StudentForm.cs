using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform大作业
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.Text = "考试管理系统--学生欢迎你--" + userHelper.studentname;
            this.WindowState = FormWindowState.Maximized;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutF = new AboutForm();
            aboutF.ShowDialog();
        }

        private void 在线考试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamForm exam = new ExamForm();
            exam.Show();
            exam.MdiParent = this;
        }
    }
}
