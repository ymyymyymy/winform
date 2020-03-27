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
    public partial class ModifyQuestion : Form
    {
        DataSet ds;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        public ModifyQuestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string question = txt_Question.Text.Trim();
            string answer;
            int difficulty;
            int subjectid = (int)com_subjevt.SelectedValue;
            string optionA = txt_A.Text.Trim();
            string optionB = txt_B.Text.Trim();
            string optionC = txt_C.Text.Trim();
            string optionD = txt_D.Text.Trim();

            if (r_A.Checked)
            {
                answer = r_A.Text;
            }
            else if (r_B.Checked)
            {
                answer = r_B.Text;
            }
            else if (r_C.Checked)
            {
                answer = r_C.Text;
            }
            else
            {
                answer = r_D.Text;
            }

            if (r_1.Checked)
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

            string sql1 = string.Format("update question set question='{0}',answer='{1}',difficulty='{2}',subjectid='{3}',optionA='{4}',optionB='{5}',optionC='{6}',optionD='{7}' WHERE questionid='{8}'",question,answer,difficulty,subjectid,optionA,optionB,optionC,optionD,questionid);
             //string sql1 = string.Format("insert into question(question,answer,difficulty,subjectid,optionA,optionB,optionC,optionD) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", question, answer, difficulty, subject, optionA, optionB, optionC, optionD);
            //try
            //{
            SqlCommand comm = new SqlCommand(sql1, DBHelper.conn);
            comm.Connection = DBHelper.conn;
            DBHelper.conn.Open();
           // comm.CommandText = string.Format("select count(*) from question where question='{0}'", question);
            //int count = (int)comm.ExecuteScalar();
            //if (count > 1)
            //{
            //    MessageBox.Show("已经存在试题，不能重复添加");
            //}
            //else
            //{
            //    MessageBox.Show("成功添加");
            //}
            int n = comm.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("试题修改成功");
            }
            else
            {
                MessageBox.Show("未成功修改试题");
            }
            //}
            //    catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);  
            //}
            //finally
            //{
            DBHelper.conn.Close();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int questionid;
        private void ModifyQuestion_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select * from subject");
                ds = new DataSet();
                adapter = new SqlDataAdapter(sql, DBHelper.conn);
                adapter.Fill(ds, "subject");
                com_subjevt.DataSource = ds.Tables["subject"];
                com_subjevt.DisplayMember = "subjectname";
                com_subjevt.ValueMember = "subjectid";
                questionid = SearchQForm.questionid;///////////////////////////////////////////////////////////
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                comm.CommandText = string.Format("select * from question where questionid ={0}", questionid);
                DBHelper.conn.Open();
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    txt_Question.Text = (string)reader["question"];
                    txt_A.Text = (string)reader["optiona"];
                    txt_B.Text = (string)reader["optionb"];
                    txt_C.Text = (string)reader["optionc"];
                    txt_D.Text = (string)reader["optiond"];
                    switch ((string)reader["answer"])
                    {
                        case "A": r_A.Checked = true; break;
                        case "B": r_B.Checked = true; break;
                        case "C": r_C.Checked = true; break;
                        case "D": r_D.Checked = true; break;
                    }
                    switch ((int)reader["difficulty"])
                    {
                        case 1: r_1.Checked = true; break;
                        case 2: r_2.Checked = true; break;
                        case 3: r_3.Checked = true; break;
                    }
                    com_subjevt.SelectedValue = reader["subjectid"];
                }
                reader.Close();
                DBHelper.conn.Close();
            }
            catch (Exception ex)
            {
                DBHelper.conn.Close();
                if(!reader.IsClosed)
                    reader.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)//上一条
        {
            button4.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)//下一条
        {

        }
    }
}
