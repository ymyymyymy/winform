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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label1.Text = "考试管理系统";
            label1.Font = new Font("楷体",22);

            label2.Text = "版本号：V1.0,版权归ymy所有";
            label2.Font = new Font("楷体",18);

            Bitmap bm = new Bitmap("flower.jpg");
            this.BackgroundImage = bm;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
