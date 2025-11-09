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
          int a =int.Parse(textBox1.Text ),b=int.Parse(textBox2.Text),c=int.Parse(textBox3.Text);
          int d = (b * b) - (4 * a * c);
            Console.WriteLine((b * b) - (4 * a * c));
            if ((4 * a * c) > b * b)
            {
                MessageBox.Show("无解");
                Environment.Exit(0);
            }
            else
            {
                d = (b * b) - (4 * a * c );
                
            }

            //JiShuan(d, b,a);
            if (d == 0)
            {

                double x = -b / (2.0 * a);
                MessageBox.Show($"有唯一解：x={x}");
            }
            else
            {

                double x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine(x1);
                double x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                    MessageBox.Show($"算式为({b}+√{d})/(2{a}) 或者({b}-√{d})/(2{a})\n有两个解：x1={x1}, x2={x2}");
             
                }
             
            }
        }

}
    

