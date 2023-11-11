namespace Ecuación___11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= 10; x++)
            {
                listBox1.Items.Add(x);
                double fx = x / (1.0 + x * x);
                listBox2.Items.Add(fx);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = 1;
            while (x1 <= 10)
            {
                listBox1.Items.Add(x1);
                double fx = x1 / (1.0 + x1 * x1);
                listBox2.Items.Add(fx);
                x1++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x2 = 1;
            do
            {
                listBox1.Items.Add(x2);
                double fx = x2 / (1.0 + x2 * x2);
                listBox2.Items.Add(fx);
                x2++;
            }
            while (x2 <= 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}