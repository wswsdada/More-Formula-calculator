namespace 项目
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 118);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 0;
            label1.Text = "a=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 112);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 1;
            label2.Text = "c=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 115);
            label3.Name = "label3";
            label3.Size = new Size(25, 17);
            label3.TabIndex = 2;
            label3.Text = "b=";
            // 
            // button1
            // 
            button1.Location = new Point(144, 197);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "开始运算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(64, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 23);
            textBox2.TabIndex = 5;
         
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(64, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 65);
            label4.Name = "label4";
            label4.Size = new Size(214, 17);
            label4.TabIndex = 7;
            label4.Text = "1元2次计算器（Quadratic Formula）";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 158);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 8;
            label5.Text = "不要输入非法字符";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 358);
            panel1.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(23, 128);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
         
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 61);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 0;
            button3.Text = "一元二次(Quadratic Formula)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 0;
            button2.Text = "数学公式";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(146, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 248);
            panel3.TabIndex = 10;
            panel3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 358);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            Text = " ";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private Button button4;
    }
}
