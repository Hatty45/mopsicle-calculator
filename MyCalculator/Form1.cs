using System.Web;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        private bool started = true;
        private int operation = 0;
        private bool error = false;

        private double previousnum = 0;
        private double currentnum = 0;
        private double answer = 0;

        public Form1()
        {
            InitializeComponent();
            //this.Size = new Size(200,300);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(200, 300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            started = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            started = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            started = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            started = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            started = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            started = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            started = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            started = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            started = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            started = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('.')) { textBox1.Text += "."; }
            started = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == Convert.ToChar("-")) { textBox1.Text = textBox1.Text.Replace("-", string.Empty); } else { textBox1.Text = textBox1.Text.Insert(0, "-"); }
            started = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            started = true;
            previousnum = 0;
            currentnum = 0;
            operation = 0;
        }

        private void button4_Click(object sender, EventArgs e) // multiply
        {
            operation = 1;
            try {
                previousnum = double.Parse(textBox1.Text);
            } catch
            {
                previousnum = 0;
            }
            textBox1.Text = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e) // divide
        {
            operation = 2;
            try
            {
                previousnum = double.Parse(textBox1.Text);
            }
            catch
            {
                previousnum = 0;
            }
            textBox1.Text = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e) // addition
        {
            operation = 3;
            try
            {
                previousnum = double.Parse(textBox1.Text);
            }
            catch
            {
                previousnum = 0;
            }
            textBox1.Text = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e) // subtraction
        {
            operation = 4;
            try
            {
                previousnum = double.Parse(textBox1.Text);
            }
            catch
            {
                previousnum = 0;
            }
            textBox1.Text = string.Empty;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            currentnum = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;

            if (operation == 1)
            {
                answer = previousnum * currentnum;
            }
            else if (operation == 2)
            {
                answer = previousnum / currentnum;
            }
            else if (operation == 3)
            {
                answer = previousnum + currentnum;
            }
            else if (operation == 4)
            {
                answer = previousnum - currentnum;
            }
            else
            {
                answer = 0;
            }

            previousnum = currentnum;
            textBox1.Text = answer.ToString();
        }
    }
}
