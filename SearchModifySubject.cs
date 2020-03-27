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
    public partial class SearchModifySubject : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        public SearchModifySubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sql = string.Format("select * from subject");
            if(!string.IsNullOrEmpty(name))
            {
                sql = string.Format("select * from subject where subjectname like '%"+name+"%'");
            }
            da = new SqlDataAdapter(sql,DBHelper.conn);
            ds = new DataSet();
            da.Fill(ds,"subject");
            dataGridView1.DataSource=ds.Tables["subject"];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要保存修改吗", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Update(ds,"subject");
                MessageBox.Show("保存成功");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("确定要删除吗", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 dataGridView1.Rows.Remove(dataGridView1.CurrentRow );
                 SqlCommandBuilder builder = new SqlCommandBuilder(da);
                 da.Update(ds, "subject");
                 MessageBox.Show("删除成功");
             }
        }
    }
}
