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
    public partial class AddClassForm : Form
    {
        //SqlConnection conn;
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void AddClassForm_Load(object sender, EventArgs e)
        {
            //this.MdiParent = TeacherForm.ActiveForm;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入班级");
            }
            else
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = DBHelper.conn;
                comm.CommandText = string.Format("select count(*) from classinfo where classname='{0}'", textBox1.Text);
                DBHelper.conn.Open();
                int n = (int)comm.ExecuteScalar();
                if (n > 0)
                {
                    MessageBox.Show("班级已经存在");
                }
                //string sql = string.Format("select classid from classinfo");
                //SqlCommand comm = new SqlCommand(sql,DBHelper.conn );
                //DBHelper.conn.Open();
                //int n = comm.ExecuteNonQuery();
                //if (n > 0)
                //{
                //    MessageBox.Show("班级已经存在");
                //}
                else
                {
                    comm.CommandText = string.Format("insert into classinfo(classname) values('{0}')",textBox1.Text);
                    int result = comm.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("添加失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("添加成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                DBHelper.conn.Close();
            }
        }
    }
}

               