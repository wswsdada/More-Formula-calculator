using System;
using System.Windows.Forms;

namespace 项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text), b = int.Parse(textBox2.Text), c = int.Parse(textBox3.Text);
            if (a == 0)
            {
                MessageBox.Show("a不能等于0"); return;
            }
            double d = (b * b) - (4 * a * c);
            Console.WriteLine((b * b) - (4 * a * c));
            if ((4 * a * c) > b * b)
            {
                d = (b * b) - (4 * a * c);
                d = Math.Abs(d);
                double x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                double x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                MessageBox.Show($"算式为({b}+√{d})/(2*{a}) 或者({b}-√{d})/(2*{a})\n有两个虚数解：x1={x1}i, x2={x2}i");
                return;
            }
            else
            {
                d = (b * b) - (4 * a * c);
            }
            if (d == 0)
            {
                double x = -b / (2.0 * a);
                MessageBox.Show($"有唯一解：x={x}，算式为{-b}/(2*{a})");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine(x1);
                double x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                MessageBox.Show($"算式为({b}+√{d})/(2{a}) 或者({b}-√{d})/(2{a})\n有两个解：x1={x1}, x2={x2}");
            }
            } catch
            {
                MessageBox.Show("请输入正确的数字"); return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }


        
    } 
}


