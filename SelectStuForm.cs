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
    public partial class SelectStuForm : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        public SelectStuForm()
        {
            InitializeComponent();
        }

        private void Select_Form_Load(object sender, EventArgs e)
        {
           // this.MdiParent = TeacherForm.ActiveForm;
            ColumnHeader h = new ColumnHeader();
            h.Text = "用户名";
            h.Width = 120;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "密码";
            h.Width = 90;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "姓名";
            h.Width = 90;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "学号";
            h.Width = 90;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "性别";
            h.Width = 90;
            listView1.Columns.Add(h);

            listView1.View = View.Details;
            listView1.GridLines = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from student");
            string name = textbox1.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                // sql += "where studentname like '%"+name+"%'";
                sql = "select * from student where studentname like '%" + name + "%'";
            }
                try
                {
                    comm = new SqlCommand(sql, DBHelper.conn);
                    DBHelper.conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    listView1.Items.Clear();
                    //else
                    //{
                    //    comm.CommandText = string.Format("select * from student where studentname like '{0}'",textBox1.Text);

                    //}
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("抱歉，没有你要查找的用户", "结果提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            string[] s = { reader["loginname"].ToString(), reader["password"].ToString(), reader["studentname"].ToString(), reader["studentno"].ToString(), reader["sex"].ToString() };
                            ListViewItem lv = new ListViewItem(s);
                            listView1.Items.Add(lv);
                            lv.Tag = reader["studentid"];
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBHelper.conn.Close();
                }
            }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n;
            n = listView1.SelectedItems.Count;
            if (n == 0)
            {
                MessageBox.Show("你还没有选择任何用户");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除吗","操作提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                if(result==DialogResult.Yes )
                {
                    foreach (ListViewItem lvi in listView1.SelectedItems)
                    {
                        int num = 0;
                        //从列表视图删除
                        listView1.Items.Remove(lvi);
                        try
                        {
                           string sql = string.Format("delete from student where studentid={0}", lvi.Tag);
                           // string sql = string.Format("delete from student where studentid={0}", listView1.SelectedItems[0].Tag );
                            comm = new SqlCommand(sql, DBHelper.conn);
                            DBHelper.conn.Open();          
                            num = comm.ExecuteNonQuery();//执行Sql语句，并返回受影响的行数
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            DBHelper.conn.Close();
                        }
                        if (num < 1)
                        {
                            MessageBox.Show("删除失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        //else
                        //{
                        //    MessageBox.Show("成功删除"+n+"条记录", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information );
                     
                        //}
                    }
                    MessageBox.Show("成功删除" + n + "条记录", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                }
            }
        }
    }
}
