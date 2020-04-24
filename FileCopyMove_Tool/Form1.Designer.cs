namespace FileCopyMove_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "시작경로 지정하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "타겟 경로 지정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 21);
            this.textBox2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 102);
            this.button3.TabIndex = 6;
            this.button3.Text = "실행하기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(86, 155);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "파일복사";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(163, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "파일이동";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 21);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this._KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "제외할 확장자";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 55);
            this.button4.TabIndex = 12;
            this.button4.Text = "확장자 초기화";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "(엔터키입력)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Delete키 삭제 가능";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "\"기본 : 모든확장자 실행\"";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(677, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 256);
            this.listBox1.TabIndex = 16;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(260, 198);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(138, 136);
            this.listBox2.TabIndex = 17;
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this._KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "복사시 기본적으로 덮어쓰기 옵션이 적용됩니다";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "제외 확장자 리스트";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(523, 21);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(139, 124);
            this.listBox3.TabIndex = 20;
            this.listBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this._OutFolderList);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 12;
            this.listBox4.Location = new System.Drawing.Point(523, 221);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(139, 124);
            this.listBox4.TabIndex = 21;
            this.listBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this._OutFileName);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "제외할 폴더명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "제외할 파일명";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "(엔터키입력)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "(엔터키입력)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(426, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(91, 21);
            this.textBox4.TabIndex = 26;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this._OutFolder);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(426, 255);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(91, 21);
            this.textBox5.TabIndex = 27;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this._OutFile);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "파일, 폴더명이 정확히 일치 해야함(확장자 까지)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "Delete키 삭제 가능";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(677, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 55);
            this.button5.TabIndex = 30;
            this.button5.Text = "리스트 초기화";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(744, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "Made By 정범호(4시간 걸림)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 366);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "폴더 내 많은 파일을 특정 경로에 몰아넣고 싶을때 사용하세요";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
    }
}

