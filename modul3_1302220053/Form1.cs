namespace modul3_1302220053
{
    public partial class Form1 : Form
    {
        int b = 0;
        int temp = 0;
        bool firstInput = true;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "1";
                b = 1;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                b = b * 10 + 1;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "4";
                b = 4;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                b = b * 10 + 4;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "0";
                b = 0;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
                b = b * 10 + 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "2";
                b = 2;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                b = b * 10 + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "3";
                b = 3;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                b = b * 10 + 3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "5";
                b = 5;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                b = b * 10 + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "6";
                b = 6;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                b = b * 10 + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "7";
                b = 7;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                b = b * 10 + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "8";
                b = 8;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                b = b * 10 + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                textBox1.Text = "9";
                b = 9;
                firstInput = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                b = b * 10 + 9;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temp = b;
            firstInput = true;
            textBox1.Text = "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = b + temp;
            textBox1.Text = b.ToString();
            b = 0;
            temp = 0;
            firstInput = true;
        }
    }
}
