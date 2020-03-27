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
    public partial class QuestionResultForm : Form
    {
        public QuestionResultForm()
        {
            InitializeComponent();
        }

        private void QuestionResultForm_Load(object sender, EventArgs e)
        {
            int correctNum = 0;
            //计算答对题目的总数
            for (int i = 0; i < QuizHelper.questionNum;i++ )
            {
                if(QuizHelper.studentAnswers[i]==QuizHelper.correctAnswers[i])
                {
                    correctNum++;
                }
            }
            //计算得分
            int score = correctNum * 100 / QuizHelper.questionNum;
            //保存分数
            string sql = string.Format("insert into score(studentname,score,subjectid) values ('0','1','2')",userHelper.studentname,score,StudentHelper.subjectId);
            SqlCommand comm = new SqlCommand(sql,DBHelper.conn);
            DBHelper.conn.Open();
            comm.ExecuteNonQuery();
            DBHelper.conn.Close();
            lab_Mark.Text = score.ToString() + "分";
            label4.Width = label5.Width * score / 100;
            label5.Width = label5.Width;
            label5.Height = 30; label4.Height = 30;
            //labFullScore.Size = new Size(labFullScore.Width,30);
            //labStudebtScore.Size = new Size(labFullScore.Width * score / 100,30);
            //labStudebtScore.Size = new Size(score, labFullScore.Size.Height);
            label5.BackColor = Color.Red;
            //根据不同的得分，显示不同的颜色
            if(score<60)
            {
                label1.Text = "该好好复习啦";
                label4.BackColor = Color.Red;
                //Bitmap bm = new Bitmap("1.jpg");
                //this.BackgroundImage = bm;
                //this.BackgroundImageLayout = ImageLayout.Zoom;
                ////图片
            }
            else if (score >= 60 && score < 85)
            {
                label1.Text = "还不错，继续努力";
                label4.BackColor = Color.Blue;
                //Bitmap bm = new Bitmap("2.jpg");
                //this.BackgroundImage = bm;
                //this.BackgroundImageLayout = ImageLayout.Zoom;
                ////
            }
            else if (score >= 85 && score < 100)
            {
                label1.Text = "优秀";
                label4.BackColor = Color.CornflowerBlue;
                //Bitmap bm = new Bitmap("3.jpg");
                //this.BackgroundImage = bm;
                //this.BackgroundImageLayout = ImageLayout.Zoom;
                //
            }
            else
            {
                label1.Text = "真厉害，全对了";
                label4.BackColor = Color.Green;
                //Bitmap bm = new Bitmap("5.jpg");
                //this.BackgroundImage = bm;
                //this.BackgroundImageLayout = ImageLayout.Zoom;
                //
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            correctAnswerForm correct = new correctAnswerForm();
            correct.Show();
        }
    }
}
