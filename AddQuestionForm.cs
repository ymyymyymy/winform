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
    public partial class AddQuestionForm : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        public AddQuestionForm()
        {
            InitializeComponent();
        }
        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from subject");
            da = new SqlDataAdapter(sql,DBHelper.conn);
            ds = new DataSet();
            da.Fill(ds,"subject");
            com_subjevt.DataSource=ds.Tables["subject"];
            com_subjevt.DisplayMember = "subjectname";
            com_subjevt.ValueMember = "subjectid";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string question = txt_Question.Text.Trim();
            string answer = "";
            int difficulty = 0;
            int subject = (int)com_subjevt.SelectedValue;
            string optionA = txt_A.Text.Trim();
            string optionB = txt_B.Text.Trim();
            string optionC = txt_C.Text.Trim();
            string optionD = txt_D.Text.Trim();

            if(r_A.Checked )
            {
                answer = r_A.Text;
            }
            else if(r_B.Checked)
            {
                answer=r_B.Text;
            }
            else if (r_C.Checked)
            {
                answer = r_C.Text;
            }
            else
            {
                answer = r_D.Text;
            }

            if(r_1.Checked )
            {
                difficulty = int.Parse(r_1.Text);
            }
            else if (r_2.Checked)
            {
                difficulty = int.Parse(r_2.Text);
            }
            else
            {
                difficulty = int.Parse(r_3.Text);
            }
            try
            {
                string sql = string.Format("select count(*) from question where question='{0}'", question);
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                int count = (int)comm.ExecuteScalar();
                if (count >= 1)
                {
                    MessageBox.Show("已经存在试题，不能重复添加");
                }
                else
                {
                    comm.CommandText = string.Format("insert into question(question,answer,difficulty,subjectid,optionA,optionB,optionC,optionD) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", question, answer, difficulty, subject, optionA, optionB, optionC, optionD);
                    int n = comm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("试题添加成功");
                    }
                    else
                    {
                        MessageBox.Show("未成功添加试题");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
