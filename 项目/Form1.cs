using System;
using System.Windows.Forms;
using System.IO;

namespace 项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   File.AppendAllText("历史记录.txt", $"{DateTime.Now}使用了一次一元二次方程求解功能，参数为：a={textBox1.Text}, b={textBox2.Text}, c={textBox3.Text}\n");
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
                MessageBox.Show($"算式为({b}+√{d})±(2*{a})\n有两个虚数解：x1={x1}i, x2={x2}i");
                File.AppendAllText("历史记录.txt", $"两个虚数解,方程{a}x²+{b}x+{c}=0的解为：x1={x1}, x2={x2}\n");
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
               File.AppendAllText("历史记录.txt", $"唯一有解，方程{a}x²+{b}x+{c}=0的解为：x1={x}\n");

            }
                else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine(x1);
                double x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                MessageBox.Show($"判别式式为({b}+√{d})±(2{a})\n有两个解：x1={x1}, x2={x2}");
                File.AppendAllText("历史记录.txt", $"方程{a}x²+{b}x+{c}=0的解为：x1={x1}, x2={x2}\n");
            }
          } 
            catch
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


