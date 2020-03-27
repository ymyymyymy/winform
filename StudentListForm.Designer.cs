namespace winform大作业
{
    partial class StudentListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_Modify = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.b_Fresh = new System.Windows.Forms.Button();
            this.b_Export = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(490, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // b_Modify
            // 
            this.b_Modify.Location = new System.Drawing.Point(43, 295);
            this.b_Modify.Name = "b_Modify";
            this.b_Modify.Size = new System.Drawing.Size(75, 23);
            this.b_Modify.TabIndex = 1;
            this.b_Modify.Text = "修改";
            this.b_Modify.UseVisualStyleBackColor = true;
            this.b_Modify.Click += new System.EventHandler(this.b_Modify_Click);
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(153, 295);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(75, 23);
            this.b_Delete.TabIndex = 2;
            this.b_Delete.Text = "删除";
            this.b_Delete.UseVisualStyleBackColor = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // b_Fresh
            // 
            this.b_Fresh.Location = new System.Drawing.Point(272, 295);
            this.b_Fresh.Name = "b_Fresh";
            this.b_Fresh.Size = new System.Drawing.Size(75, 23);
            this.b_Fresh.TabIndex = 3;
            this.b_Fresh.Text = "刷新";
            this.b_Fresh.UseVisualStyleBackColor = true;
            this.b_Fresh.Click += new System.EventHandler(this.b_Fresh_Click);
            // 
            // b_Export
            // 
            this.b_Export.Location = new System.Drawing.Point(376, 295);
            this.b_Export.Name = "b_Export";
            this.b_Export.Size = new System.Drawing.Size(93, 23);
            this.b_Export.TabIndex = 4;
            this.b_Export.Text = "导出到excel";
            this.b_Export.UseVisualStyleBackColor = true;
            this.b_Export.Click += new System.EventHandler(this.b_Export_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 330);
            this.Controls.Add(this.b_Export);
            this.Controls.Add(this.b_Fresh);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Modify);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentListForm";
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_Modify;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.Button b_Fresh;
        private System.Windows.Forms.Button b_Export;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}