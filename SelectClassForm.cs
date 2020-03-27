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
    public partial class SelectClassForm : Form
    {
        SqlDataAdapter adapter;
        DataSet dataset;
        public SelectClassForm()
        {
            InitializeComponent();
        }

        private void SelectClassForm_Load(object sender, EventArgs e)
        {

        }

        private void b_Select_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from classinfo");
            string name = textBox1.Text;
            if (!string.IsNullOrEmpty(name))
            {
                sql = string.Format("select * from classinfo where classname='{0}'", name);
            }
            try
            {
                adapter = new SqlDataAdapter(sql, DBHelper.conn);
                dataset = new DataSet();
                adapter.Fill(dataset, "classinfo");
                dataGridView1.DataSource = dataset.Tables["classinfo"];
                //dataGridView1.Columns[0].Width = 200;
                //dataGridView1.Columns[1].Width = 200;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        private void b_Save_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("确定要保存修改吗","操作提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
            if(result==DialogResult.Yes)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataset,"classinfo");
                MessageBox.Show("保存成功");
            }
        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除吗", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id=(int)dataset.Tables["classinfo"].Rows[dataGridView1.CurrentRow.Index][0];
                string sql = string.Format("select count(*) from student where classid={0}",id);
                SqlCommand comm = new SqlCommand(sql,DBHelper.conn);
                DBHelper.conn.Open();
                int n = (int)comm.ExecuteScalar();
                DBHelper.conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("该班级有学生不能删除");
                    return;
                }
                else
                {
                    dataset.Tables["classinfo"].Rows[dataGridView1.CurrentRow.Index].Delete();
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dataset, "classinfo");
                    MessageBox.Show("删除成功");
                }
                
            }
        }
    }
}
