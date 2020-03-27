namespace winform大作业
{
    partial class AddQuestionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_D = new System.Windows.Forms.RadioButton();
            this.r_B = new System.Windows.Forms.RadioButton();
            this.r_C = new System.Windows.Forms.RadioButton();
            this.r_A = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.com_subjevt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.r_1 = new System.Windows.Forms.RadioButton();
            this.r_2 = new System.Windows.Forms.RadioButton();
            this.r_3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_D);
            this.groupBox1.Controls.Add(this.r_B);
            this.groupBox1.Controls.Add(this.r_C);
            this.groupBox1.Controls.Add(this.r_A);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_D);
            this.groupBox1.Controls.Add(this.txt_A);
            this.groupBox1.Controls.Add(this.txt_C);
            this.groupBox1.Controls.Add(this.txt_B);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Question);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "试题基本信息";
        //    this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // r_D
            // 
            this.r_D.AutoSize = true;
            this.r_D.Location = new System.Drawing.Point(393, 240);
            this.r_D.Name = "r_D";
            this.r_D.Size = new System.Drawing.Size(29, 16);
            this.r_D.TabIndex = 15;
            this.r_D.TabStop = true;
            this.r_D.Text = "D";
            this.r_D.UseVisualStyleBackColor = true;
            // 
            // r_B
            // 
            this.r_B.AutoSize = true;
            this.r_B.Location = new System.Drawing.Point(247, 240);
            this.r_B.Name = "r_B";
            this.r_B.Size = new System.Drawing.Size(29, 16);
            this.r_B.TabIndex = 14;
            this.r_B.TabStop = true;
            this.r_B.Text = "B";
            this.r_B.UseVisualStyleBackColor = true;
            // 
            // r_C
            // 
            this.r_C.AutoSize = true;
            this.r_C.Location = new System.Drawing.Point(317, 240);
            this.r_C.Name = "r_C";
            this.r_C.Size = new System.Drawing.Size(29, 16);
            this.r_C.TabIndex = 13;
            this.r_C.TabStop = true;
            this.r_C.Text = "C";
            this.r_C.UseVisualStyleBackColor = true;
       //     this.r_C.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // r_A
            // 
            this.r_A.AutoSize = true;
            this.r_A.Location = new System.Drawing.Point(167, 239);
            this.r_A.Name = "r_A";
            this.r_A.Size = new System.Drawing.Size(29, 16);
            this.r_A.TabIndex = 12;
            this.r_A.TabStop = true;
            this.r_A.Text = "A";
            this.r_A.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "答案";
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(89, 196);
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(389, 21);
            this.txt_D.TabIndex = 10;
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(89, 115);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(389, 21);
            this.txt_A.TabIndex = 9;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(89, 169);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(389, 21);
            this.txt_C.TabIndex = 8;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(89, 142);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(389, 21);
            this.txt_B.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "A";
            // 
            // txt_Question
            // 
            this.txt_Question.Location = new System.Drawing.Point(74, 29);
            this.txt_Question.Multiline = true;
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Question.Size = new System.Drawing.Size(404, 80);
            this.txt_Question.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选项";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "题目";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.com_subjevt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.r_1);
            this.groupBox2.Controls.Add(this.r_2);
            this.groupBox2.Controls.Add(this.r_3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(28, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "试题附加信息";
            // 
            // com_subjevt
            // 
            this.com_subjevt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_subjevt.FormattingEnabled = true;
            this.com_subjevt.Location = new System.Drawing.Point(306, 33);
            this.com_subjevt.Name = "com_subjevt";
            this.com_subjevt.Size = new System.Drawing.Size(171, 20);
            this.com_subjevt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "科目";
      //      this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // r_1
            // 
            this.r_1.AutoSize = true;
            this.r_1.Location = new System.Drawing.Point(93, 34);
            this.r_1.Name = "r_1";
            this.r_1.Size = new System.Drawing.Size(29, 16);
            this.r_1.TabIndex = 15;
            this.r_1.TabStop = true;
            this.r_1.Text = "1";
            this.r_1.UseVisualStyleBackColor = true;
            // 
            // r_2
            // 
            this.r_2.AutoSize = true;
            this.r_2.Location = new System.Drawing.Point(139, 34);
            this.r_2.Name = "r_2";
            this.r_2.Size = new System.Drawing.Size(29, 16);
            this.r_2.TabIndex = 14;
            this.r_2.TabStop = true;
            this.r_2.Text = "2";
            this.r_2.UseVisualStyleBackColor = true;
            // 
            // r_3
            // 
            this.r_3.AutoSize = true;
            this.r_3.Location = new System.Drawing.Point(186, 33);
            this.r_3.Name = "r_3";
            this.r_3.Size = new System.Drawing.Size(29, 16);
            this.r_3.TabIndex = 13;
            this.r_3.TabStop = true;
            this.r_3.Text = "3";
            this.r_3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "难度等级";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
      //      this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddQuestionForm";
            this.Text = "添加试题";
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Question;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton r_D;
        private System.Windows.Forms.RadioButton r_B;
        private System.Windows.Forms.RadioButton r_C;
        private System.Windows.Forms.RadioButton r_A;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.ComboBox com_subjevt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton r_1;
        private System.Windows.Forms.RadioButton r_2;
        private System.Windows.Forms.RadioButton r_3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}