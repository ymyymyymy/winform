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
    public partial class QuestionsForm : Form
    {
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minute;//分钟
            int second;//秒
            if (QuizHelper.remainSeconds > 0)
            {
                QuizHelper.remainSeconds--;
                minute = QuizHelper.remainSeconds / 60;
                second = QuizHelper.remainSeconds % 60;
                label1.Text = string.Format("{0:00}:{1:00}", minute, second);
            }
            else
            {
               // timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("时间到了，该交卷了","操作提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                QuestionResultForm questionresultForm = new QuestionResultForm();
                questionresultForm.MdiParent = this.MdiParent;
                questionresultForm.Show();
                this.Close();
            }
        }
        public static int questionIndex =0;
        private void QuestionsForm_Load(object sender, EventArgs e)
        {
           // timer1.Start();
            timer1.Enabled = true;
            GetQuestionDetails();
            b_up.Enabled = false;
        }
        private void GetQuestionDetails()
        {
            label2.Text = string.Format("问题{0}", questionIndex+1);
                string sql = string.Format("select question,optiona,optionb,optionc,optiond from question where questionid={0}", QuizHelper.selectedQuestionIds[questionIndex]);
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader["question"].ToString();
                    radioButtonA.Text = string.Format("A.{0}", reader["optionA"].ToString());
                    radioButtonB.Text = string.Format("B.{0}", reader["optionB"].ToString());
                    radioButtonC.Text = string.Format("C.{0}", reader["optionC"].ToString());
                    radioButtonD.Text = string.Format("D.{0}", reader["optionD"].ToString());
                }
       
            reader.Close();
            DBHelper.conn.Close(); 
            
        }
        private void CheckOption()//如果已经答了题目，选择相应的选项
        {
            switch(QuizHelper.selectedQuestionIds[questionIndex])
            {
                case 'A': radioButtonA.Checked = true; break; //QuizHelper.studentAnswers ='A';
                case 'B': radioButtonA.Checked = true; break;
                case 'C': radioButtonA.Checked = true; break;
                case 'D': radioButtonA.Checked = true; break;
                default: 
                    radioButtonA.Checked = false;
                    radioButtonB.Checked = false;
                    radioButtonC.Checked = false;
                    radioButtonD.Checked = false; 
                    break;

            }
        }

        private void b_up_Click(object sender, EventArgs e)//上一题
        {
            b_next.Enabled = true;
            if (questionIndex ==0)
            {
                b_up.Enabled = false;
            }
            else
            {
                b_up.Enabled = true;
                questionIndex--;
                GetQuestionDetails();//显示试题信息
                CheckOption();//试题答过，选项选中
            }
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            b_up.Enabled = true;
            if (questionIndex < QuizHelper.selectedQuestionIds.Length - 1)
            {
                questionIndex++;
                GetQuestionDetails();//显示试题信息
                CheckOption();//试题答过，选项选中
            }
            else
            {
                b_next.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionCardForm questioncardForm = new QuestionCardForm();
            questioncardForm.Show();
            questioncardForm.MdiParent = this.MdiParent;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonA__Click(object sender, EventArgs e)
        {
            QuizHelper.studentAnswers[questionIndex] = Convert.ToString(((RadioButton)sender).Tag);
        }
    }
}
