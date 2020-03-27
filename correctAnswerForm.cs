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
    public partial class correctAnswerForm : Form
    {
        public correctAnswerForm()
        {
            InitializeComponent();
        }

        private void correctAnswerForm_Load(object sender, EventArgs e)
        {
            int Index = 0;
            //遍历窗体上的所有控件
            string stuA;
            string corrA;
            foreach(Control item in this.Controls)
            {
                if(item is Label)
                {
                    Index =Convert.ToInt32( item.Tag);
                    stuA = QuizHelper.studentAnswers[Index];
                    corrA=QuizHelper.correctAnswers[Index];
                    if(stuA==corrA)
                    {
                        item.ForeColor = Color.Red;
                    }
                    item.Text = corrA;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < QuizHelper.studentAnswers.Length;i++ )
            {
                QuizHelper.studentAnswers[i]=QuizHelper.correctAnswers[i];
            }
            int questionIndex = Convert.ToInt32(((Button)sender).Tag);
            QuestionsForm questionF = new QuestionsForm();
            QuestionsForm.questionIndex = questionIndex;
            questionF.MdiParent = this.MdiParent;
            questionF.Show();
            this.Close();
        }
    }
}
