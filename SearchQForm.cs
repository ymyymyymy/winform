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
    public partial class SearchQForm : Form
    {
        public SearchQForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
           string sql = "select questionid,answer,difficulty,question,optiona,optionb,optionc,optionc,optiond,subjectname from question inner join subject on (question.subjectid=subject.subjectid)";
            // string sql = "select * from question";
            if(!string.IsNullOrEmpty(name))
            {
                //sql = sql + "where question like '%" + name + "%'";
                sql ="select * from subject where subjectname like '%" + name + "%'";
              sql=  "select questionid,answer,difficulty,question,optiona,optionb,optionc,optionc,optiond,subjectname from question inner join subject on (question.subjectid=subject.subjectid) where subjectname like '%" + name + "%'";
          
            }
            try
            {
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                listView1.Items.Clear();

                if (!reader.HasRows)//没有数据
                {
                    MessageBox.Show("抱歉，没有你要找的试题");
                }
                else
                {
                    while (reader.Read())
                    {
                        string[] s = { reader["answer"].ToString(), reader["difficulty"].ToString(), reader["question"].ToString(), reader["optiona"].ToString(), reader["optionb"].ToString(), reader["optionc"].ToString(), reader["optiond"].ToString(), reader["subjectname"].ToString() };
                        ListViewItem lv = new ListViewItem(s);
                        listView1.Items.Add(lv);
                        lv.Tag = reader["questionid"];
                    }
                }
                reader.Close();
            }
                catch(Exception ex)  
           {
               MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }

        private void SearchQForm_Load(object sender, EventArgs e)
        {
            ColumnHeader h = new ColumnHeader();
           
            h = new ColumnHeader();
            h.Text = "答案";
            h.Width = 120;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "难度等级";
            h.Width = 120;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "题目";
            h.Width = 120;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text="选项A";
            h.Width = 120;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "选项B";
            h.Width = 120;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "选项C";
            h.Width = 120;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "选项D";
            h.Width = 120;
            listView1.Columns.Add(h);

            h = new ColumnHeader();
            h.Text = "课程名称";
            h.Width = 120;
            listView1.Columns.Add(h);

            listView1.View = View.Details;
            listView1.GridLines = true;
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = 0;
            if(listView1.Items.Count==0)
            {
                MessageBox.Show("你没有选择任何科目");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除吗","操作提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string sql = string.Format("delete from question where questionid='{0}'", listView1.SelectedItems[0].Tag);
                        SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                        DBHelper.conn.Open();
                        num = comm.ExecuteNonQuery();
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
                        MessageBox.Show("删除失败");
                    }
                    else
                    {
                        MessageBox.Show("成功删除"+num+"条记录");
                    }
                }
            }
        }

        public static int questionid;
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("你没有选择任何试题");
            }
            else
            {
                ModifyQuestion mq = new ModifyQuestion();
                questionid =(int)listView1.SelectedItems[0].Tag;
                mq.Show();
            }

        }
    }
}
