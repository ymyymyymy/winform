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
using Common;
namespace winform大作业
{
    public partial class ExamForm : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;
        public ExamForm()
        {
            InitializeComponent();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("楷体", 18);
            label3.Font = new Font("label3.Font", 8);
          //  ExamForm.questionIndex = 0;
            ds = new DataSet();
            string sql = "select * from subject";
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            adapter.Fill(ds, "subject");
            comboBox1.DataSource = ds.Tables["subject"];
            comboBox1.DisplayMember = "subjectname";
            comboBox1.ValueMember = "subjectid";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("真想放弃吗", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
              //  this.Close();
                QuestionResultForm f = new QuestionResultForm();
                f.Show();
            }
        }
        private int GetQuestionCount(int subjectid)//获取该科目试题总数
        {
            int questionCount = 0;
            string sql = "select count(*) from question where subjectid=" + subjectid;
            SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
            DBHelper.conn.Open();
            questionCount = (int)comm.ExecuteScalar();
            DBHelper.conn.Close();
            return questionCount;

        }

        private void SetAllQuestionIds(int subjectid)//获取某科目所有试题的id
        {
            //try
            //{

            string sql = "select questionid from question where subjectid=" + subjectid;
            SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
            DBHelper.conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            for (int i = 0; i < QuizHelper.allQuestionIds.Length; i++)
            {
                if (reader.Read())
                {
                    //为所有问题id数组元素赋值
                    QuizHelper.allQuestionIds[i] = Convert.ToInt32(reader["questionid"]);
                    QuizHelper.selectedStates[i] = false;
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            DBHelper.conn.Close();
            //}
        }
        private void SetselectQuestionIds()//抽取试题
        {
            Random ran = new Random();
            //记录抽取了几道试题
            //try
            //{
            int i = 0;
            int questionIndex = 0;
            while(i < QuizHelper.questionNum)
            {
                questionIndex = ran.Next(QuizHelper.allQuestionIds.Length);

                if (QuizHelper.selectedStates[questionIndex] == false)
                {
                    QuizHelper.selectedQuestionIds[i] = QuizHelper.allQuestionIds[questionIndex];
                    QuizHelper.selectedStates[questionIndex]=true;
                    i++;
                }             
            }
        }
        private void SetRightAnswer()//获取正确答案
        {
           
            for (int i = 0; i < QuizHelper.selectedQuestionIds.Length; i++)
            {
               // string sql = "";
                SqlCommand comm = new SqlCommand();
                comm.Connection = DBHelper.conn;
                DBHelper.conn.Open();
                  //try
                //{
                // comm = new SqlCommand(sql, DBHelper.conn);
                comm.CommandText = string.Format("select answer from question where questionid={0}", QuizHelper.selectedQuestionIds[i]);
              
               // string id = comm.CommandText;
              
                //  LocalLog.TrackingLog("查询结果", "答案ID", comm.CommandText.ToString());
                string s = comm.ExecuteScalar().ToString();
                if (s!= null)
                {
                  QuizHelper.correctAnswers[i] = s;//为标准答案数组赋值
                }
                //else
                //{
                //    MessageBox.Show("尚未进行选择");
                //}
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                DBHelper.conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获得选中科目的id
            int subjectid = (int)comboBox1.SelectedValue;
            StudentHelper.subjectId = subjectid;
            //该科目的问题总数
            int allquestioncount = GetQuestionCount(subjectid);
            if (allquestioncount < QuizHelper.questionNum)
            {
                MessageBox.Show("试题数量少于20条，不能获取试题");
                return;
            }
            //指定所有问题数组的长度
            QuizHelper.allQuestionIds = new int[allquestioncount];
            //指定问题是否选中的数组的长度
            QuizHelper.selectedStates = new bool[allquestioncount];
            //为所有问题数组赋值，赋予所有问题的id号
            SetAllQuestionIds(subjectid);
            //抽取questionid
            SetselectQuestionIds();
            //取出标准答案
            SetRightAnswer();
            //剩余时间为20分钟
            QuizHelper.remainSeconds = 1200;
            //将学生答案数组初始化
            for (int i = 0; i < QuizHelper.studentAnswers.Length; i++)
            {
                QuizHelper.studentAnswers[i] = "未回答";
            }
            //打开答案窗体
            QuestionsForm questionForm = new QuestionsForm();
            questionForm.MdiParent = this.MdiParent;
            questionForm.Show();
        }
    }
}
