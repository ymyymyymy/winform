using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winform大作业
{
    public partial class TeacherForm : Form
    {
        SqlCommand comm;
        Random ran = new Random();
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void Teacher_Form_Load(object sender, EventArgs e)
        {
            this.Text = "考试管理系统--教师欢迎你--" + userHelper.teachername;
            this.WindowState = FormWindowState.Maximized;
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!ExistMdiChildren("AddStudentForm"))
            {
            AddStudentForm add = new AddStudentForm();
            add.MdiParent = this;
            add.Show();
            }
        }
        private bool ExistMdiChildren(String MdiChildrenClassName)
        {
            foreach(Form childForm in this.MdiChildren)
            {
                if(childForm.Name==MdiChildrenClassName )//如果存在
                {
                    if(childForm.WindowState==FormWindowState.Minimized)
                    {
                        childForm.WindowState = FormWindowState.Maximized;
                    }
                    childForm.Activate();
                    return true;
                }
            }
            return false;
        }
        private void 学生人数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comm = new SqlCommand();
           // comm.Connection = DBHelper.conn;
            string sql = string.Format("select count(*) from student");
           // comm.CommandText = string.Format("select count(*) from student");
            comm = new SqlCommand(sql, DBHelper.conn);
            DBHelper.conn.Open();
            int n = (int)comm.ExecuteScalar();
            MessageBox.Show("学生人数"+n);
        }

        private void 查询删除学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExistMdiChildren("SelectStuForm"))
            {
                SelectStuForm selectstuForm = new SelectStuForm();
                selectstuForm.MdiParent = this;
                selectstuForm.Show();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void TeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
             DialogResult result = MessageBox.Show("确定退出吗","操作提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
             if (result == DialogResult.Yes)
             {
                 e.Cancel = false;
             }
             else
             {
                 e.Cancel = true;
             }
        }

        private void 学生信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExistMdiChildren("StudentListForm"))
            {
                StudentListForm stuList = new StudentListForm();
                stuList.MdiParent = this;
                stuList.Show();
            }
        }

        private void 添加班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExistMdiChildren("AddClassForm"))
            {
                AddClassForm add = new AddClassForm();
                add.MdiParent = this;
                add.Show();
            }
        }

        private void 查询删除班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExistMdiChildren("SelectClassForm"))
            {
                SelectClassForm sel = new SelectClassForm();
                sel.MdiParent = this;
                sel.Show();
            }
        }

        private void 添加科目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExistMdiChildren("AddSubject"))
            {
                AddSubject add = new AddSubject();
                add.MdiParent = this;
                add.Show();
            }
        }

        private void 查询修改删除科目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExistMdiChildren("SearchModifySubject"))
            {
                SearchModifySubject sms = new SearchModifySubject();
                sms.MdiParent = this;
                sms.Show();
            }
        }

        private void 添加试题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!ExistMdiChildren("AddQuestionForm"))
            {
            AddQuestionForm add = new AddQuestionForm();
            add.MdiParent = this;
            add.Show();
            }
        }

        private void 查询修改试题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExistMdiChildren("SearchQForm"))
            {
                SearchQForm sqf = new SearchQForm();
                sqf.MdiParent = this;
                sqf.Show();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!ExistMdiChildren("AboutForm"))
            {
                AboutForm af = new AboutForm();
                af.MdiParent = this;
                af.Show();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 辅助功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
              }

        private void 显示当前系统时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            toolStripStatusLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss");
        }

        private void 改变窗体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor  = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
            timer1.Interval = 200;
        }

    }
}
