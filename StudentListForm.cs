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
    public partial class StudentListForm : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapter;
        DataSet dataset;
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            dataset = new DataSet();
            string sql = string.Format("select studentid,loginname,studentname,phone,address from student");
            //创建DataAdapter对象 
            adapter = new SqlDataAdapter(sql,DBHelper.conn );
            //填充数据集
            adapter.Fill(dataset,"student");
            dataGridView1.DataSource=dataset.Tables["student"];
        }

        private void b_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("确定修改吗", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //自动生成更新数据库的命令
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    //将修改过的数据提交到数据库
                    adapter.Update(dataset, "student");
                    MessageBox.Show("修改成功","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void delete()
        {

        }
        private void b_Delete_Click(object sender, EventArgs e)
        {
            int n = 0;
            n=dataGridView1.SelectedRows.Count;
            DialogResult result = MessageBox.Show("确定删除吗", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               // dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                if ( dataGridView1.SelectedRows[0].Index == dataGridView1.RowCount - 1)
                {
                    MessageBox.Show(string.Format("删除不成功，原因在位置{0}处没有任何行。", dataGridView1.SelectedRows[0].Index + 1));
                    return;
                }
                for (int i = 0; i < n; i++)
                    {
                        dataset.Tables["student"].Rows[dataGridView1.CurrentRow.Index].Delete();
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dataset, "student");
                    }
                MessageBox.Show("删除成功" + n + "记录", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b_Fresh_Click(object sender, EventArgs e)
        {
            dataset.Tables["student"].Clear();
            adapter.Fill(dataset,"student");
        }

        private void b_Export_Click(object sender, EventArgs e)
        {
           /* //saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            string fname;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fname = saveFileDialog1.FileName;

                if (dataGridView1.Rows.Count == 0)
                    return;
                //实例化一个Excel.Application对象
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                //让后台执行设置为不可见，为true的话会看到打开一个Excel，然后数据在往里写
                 //excel.Visible = false;
               excel.Visible = true;
                //新增加一个工作簿，Workbook是直接保存，不会弹出保存对话框，加上Application会弹出保存对话框，值为false会报错
               excel.Application.Workbooks.Add(true);
               // excel.SaveWorkspace();
                //生成Excel中列头名称
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    excel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                //把DataGridView当前页的数据保存在Excel中
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + dataGridView1[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
                        }
                    }
                }
            }*/
            string saveFileName = "";
            saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
            //写入标题             
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            { worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText; }
            //写入数值
            for (int r = 0; r < dataGridView1.Rows.Count; r++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dataGridView1.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show("资料保存成功到" + saveFileName , "提示", MessageBoxButtons.OK);
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
                }
                catch (Exception ex)
                {//fileSaved = false;                      
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁           
        }
    }
}

