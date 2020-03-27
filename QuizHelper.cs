using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform大作业
{
   public  class QuizHelper
    {
       /// <summary>
       /// 答题总时间
       /// </summary>
        public static int totalSeconds = 1200;
       /// <summary>
       /// 剩余时间
       /// </summary>
        public static int remainSeconds = 1200;
       /// <summary>
       /// 所有问题的id
       /// </summary>
        public static int[] allQuestionIds;
       /// <summary>
       /// 记录对应索引的问题是否被随机抽中
       /// </summary>
        public static bool[] selectedStates;
       /// <summary>
       /// 题目数量
       /// </summary>
        public static int questionNum = 20;
       /// <summary>
       /// 被选中的问题id
       /// </summary>
        public static int[] selectedQuestionIds=new int[20];
       /// <summary>
       /// 标准答案数组
       /// </summary>
        public static string[] correctAnswers=new string[20];
       /// <summary>
       /// 学生答案数组
       /// </summary>
        public static string[] studentAnswers=new string[20];
    }
}
