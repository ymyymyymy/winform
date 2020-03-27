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
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        TeacherForm t_Form;
        StudentForm s_Form;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Font = new Font("隶书",18);
            label3.Font = new Font("隶书", 18);
            label4.Font = new Font("隶书", 18);
            txt_name.Font = new Font("隶书", 18);
            txt_password.Font = new Font("隶书", 18);
            txt_type.Font = new Font("隶书", 18);
            b_login.Font = new Font("隶书", 18);
            b_cancel.Font = new Font("隶书", 18);
            txt_type.Items.Add("教师");
            txt_type.Items.Add("学生");
            Bitmap bm = new Bitmap("flower.jpg");
            this.BackgroundImage = bm;
            this.BackgroundImageLayout = ImageLayout.Zoom;
           /* try
            {

                conn = new SqlConnection();
                comm = new SqlCommand();
                conn.ConnectionString = "server=(local);database=myschool;trusted_connection=yes";
                conn.Open();
                comm.Connection = conn;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }*/

        }

        private void b_login_Click(object sender, EventArgs e)
        {
            if(txt_name.Text=="")
            {
                MessageBox.Show("请输入用户名","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information );
                return;
            }
            if(txt_password.Text=="")
            {
                MessageBox.Show("请输入密码", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txt_type.Text=="")
            {
                MessageBox.Show("请选择操作类型", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string username = txt_name.Text.Trim();
            string password = txt_password.Text.Trim();

            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=myschool;Integrated Security=true");
                conn.Open();
                comm = new SqlCommand();
                comm.Connection = conn;

                if (txt_type.Text.Trim() == "教师")//txt_type.SelectedItem == "教师"
                {
                    userHelper.teachername = username;
                    comm.CommandText = string.Format("select count(*) from teacher where loginname='{0}' and password='{1}'", username, password);
                    object n = comm.ExecuteNonQuery();
                    if (n != null)
                    {
                        if (t_Form == null || t_Form.IsDisposed)
                        {
                            //userHelper.teachername = username;
                            t_Form = new TeacherForm();
                           // t_Form.Text = "考试管理系统--教师欢迎您--" + username;
                            t_Form.Show();
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }
                else
                {
                    userHelper.studentname = username;
                    comm.CommandText = string.Format("select count(*) from student where loginname='{0}' and password='{1}'", username, password);
                    object n = comm.ExecuteNonQuery();
                    if (n != null)
                    {
                        if (s_Form == null || s_Form.IsDisposed)
                        {
                            s_Form = new StudentForm();
                         //   s_Form.Text = "学生管理系统--" + username;
                            s_Form.Show();
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }

        }

       
        
    }
}
