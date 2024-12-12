using System.Security.Cryptography;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double num1 = 0;
        public string calc = "";
        public double sum = 0;
        public double diff = 0;
        public double pdt = 0;
        public double div = 0;
        public double mod = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = SevenBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + SevenBtn.Text;
            }

        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = EightBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + EightBtn.Text;
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = NineBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + NineBtn.Text;
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = FourBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + FourBtn.Text;
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = FiveBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + FiveBtn.Text;
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = SixBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + SixBtn.Text;
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = OneBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + OneBtn.Text;
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = TwoBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + TwoBtn.Text;
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = ThreeBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + ThreeBtn.Text;
            }
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = ZeroBtn.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text + ZeroBtn.Text;
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(DisplayBox.Text);
            DisplayBox.Text = "0";
            calc = "add";


        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            if (calc == "add")
            {
                sum = num1 + Convert.ToDouble(DisplayBox.Text);
                DisplayBox.Text = sum.ToString();
                num1 = 0;
                sum = 0;
                calc = "";
            }
            else if (calc == "diff")
            {
                diff = num1 - Convert.ToDouble(DisplayBox.Text);
                DisplayBox.Text = diff.ToString();
                num1 = 0;
                diff = 0;
                calc = "";
            }

            else if (calc == "product")
            {
                pdt = num1 * Convert.ToDouble(DisplayBox.Text);
                DisplayBox.Text = pdt.ToString();
                num1 = 0;
                pdt = 0;
                calc = "";
            }

            else if (calc == "division")
            {
                div = num1 / Convert.ToDouble(DisplayBox.Text);
                DisplayBox.Text = div.ToString();
                num1 = 0;
                div = 0;
                calc = "";
            }
            else if (calc == "modulus")
            {
                mod = num1 / Convert.ToDouble(DisplayBox.Text);
                DisplayBox.Text = mod.ToString();
                num1 = 0;
                mod = 0;
                calc = "";
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "0";
            sum = 0;
            num1 = 0;
            calc = "";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
            
        {
            
            
                num1 = Convert.ToDouble(DisplayBox.Text);
                DisplayBox.Text = "0";
                calc = "diff";
            
            
                
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(DisplayBox.Text);
            DisplayBox.Text = "0";
            calc = "product";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(DisplayBox.Text);
            DisplayBox.Text = "0";
            calc = "division";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(DisplayBox.Text);
            DisplayBox.Text = "0";
            calc = "modulus";
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + DotBtn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text.Remove(DisplayBox.Text.Length - 1);
        }
    }
}
