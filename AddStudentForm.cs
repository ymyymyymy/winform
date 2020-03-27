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
    public partial class AddStudentForm : Form
    {
        SqlCommand comm;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {
            radioMale.Checked=true;
           // this.MdiParent = TeacherForm.ActiveForm;
            string sql = string.Format("select * from classinfo");
            try
            {
                //定义command对象
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                //打开数据库连接
                DBHelper.conn.Open();
                //执行查询
                SqlDataReader reader = comm.ExecuteReader();
                com_class.Items.Clear();
                //循环读出所有的班级名，并添加到班级combox中
                while (reader.Read())
                {
                    string className = (string)reader["ClassName"];
                    com_class.Items.Add(className);
                }
                reader.Close();//关闭DataReader对象
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();//关闭数据库连接
            }
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if(Input())
            {
                string loginname=txt_name.Text;
                string password=txt_password.Text;
                string studentname=text_name.Text;
                string studentno=txt_num.Text;
                string phone=txt_tel.Text;
                string address=txt_address.Text;
                string sex=radioMale.Checked?"男":"女";
                int classid=GetClassName(com_class.Text);
                try
                {
                string sql=string.Format("insert into student (loginname,password,studentname,studentno,phone,address,sex,classid) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",loginname,password,studentname,studentno,phone,address,sex,classid);
                comm=new SqlCommand(sql,DBHelper.conn);
                DBHelper.conn.Open();
                int result=comm.ExecuteNonQuery();
                if(result<1)
                {
                    MessageBox.Show("添加失败","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("添加成功","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBHelper.conn.Close();
                }
            }
        }
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
        private int GetClassName(string classname)
        {
            int classid=0;
            try
            {
                string sql = string.Format("select classid from classinfo where classname='{0}'", classname);
                comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    classid = (int)reader["classid"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库语句错误" + ex.Message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return classid;
        }
        private bool Input()
        {
            if(txt_name.Text=="")
            {
                MessageBox.Show("请输入用户名","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if(txt_password.Text=="")
            {
                MessageBox.Show("请输入密码","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if(txt_again_pass.Text=="")
            {
                MessageBox.Show("请输入确认密码","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if(txt_password.Text!=txt_again_pass.Text )
            {
                MessageBox.Show("您输入的两次密码不一致","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if(text_name.Text=="")
            {
                MessageBox.Show("请输入姓名","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if(txt_num.Text=="")
            {
                MessageBox.Show("请输入学号","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if(txt_tel.Text=="")
            {
                MessageBox.Show("请输入电话","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if(com_class.Text=="")
            {
                MessageBox.Show("请输入班级","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if(txt_address.Text=="")
            {
                MessageBox.Show("请输入地址","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            return true;
            }
        }

    }

