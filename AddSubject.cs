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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=txt_name.Text.Trim();
            string time=txt_time.Text.Trim();
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(time))
            {
                MessageBox.Show("科目或学时不能为空");
            }
            else
            {
                try
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = DBHelper.conn;
                    DBHelper.conn.Open();
                    comm.CommandText = string.Format("select count(*) from subject where subjectname='{0}'", name);
                    int n = (int)comm.ExecuteScalar();
                    if (n > 0)
                    {
                        MessageBox.Show("该科目已经存在不能重复添加");
                    }
                    else
                    {
                        comm.CommandText = string.Format("insert into subject(subjectname,hours) values('{0}','{1}') ", name, time);
                        int count = comm.ExecuteNonQuery();
                        if (count < 1)
                        {
                            MessageBox.Show("添加失败");
                        }
                        else
                        {
                            MessageBox.Show("添加成功");
                        }
                    }
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
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
