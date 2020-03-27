using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform大作业
{
    public partial class QuestionCardForm : Form
    {
        public QuestionCardForm()
        {
            InitializeComponent();
        }

        private void QuestionCardForm_Load(object sender, EventArgs e)
        {
            int Index=0;
            foreach(Control item in this.Controls)
            {
                if(item is Label )//如果是标签的话。就在标签上显示学生回答的答案
                {
                    Index = Convert.ToInt32(item.Tag);
                    if(Index !=-1)
                    {
                        item.Text=QuizHelper.studentAnswers[Index];
                    }
                }
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int questionIndex = Convert.ToInt32(((Button)sender).Tag);
            int q = questionIndex - 1;        
            QuestionsForm questionF =new QuestionsForm();      
            //将题目的索引传到回答问题窗体
            QuestionsForm.questionIndex = q;
            questionF.MdiParent=this.MdiParent;
            questionF.Show();
            this.Close();
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
                MessageBox.Show("时间到了，该交卷了", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                QuestionResultForm questionresultForm = new QuestionResultForm();
                questionresultForm.MdiParent = this.MdiParent;
                questionresultForm.Show();
                this.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定交卷吗","操作提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
            if(result==DialogResult.Yes)
            {
              QuestionResultForm questionresultform = new QuestionResultForm();
              questionresultform.ShowDialog();
            }
        }
    }
}
