using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Advance_Calculator
{
    public partial class Form1 : Form
    {
        private double FirstNumber;
        private string Operation;

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        private void nAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox.Text);
            Operation = "+";
            txtBox.Text = string.Empty;

        }

        private void nMines_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox.Text);
            Operation = "-";
            txtBox.Text = string.Empty;

        }

        private void nMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox.Text);
            Operation = "*";
            txtBox.Text = string.Empty;

        }

        private void nDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox.Text);
            Operation = "/";
            txtBox.Text = string.Empty;

        }
        private void nPower_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox.Text);
            Operation = "**";
            txtBox.Text = string.Empty;

        }
        private void nMandeh_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox.Text);
            Operation = "%";
            txtBox.Text = string.Empty;

        }

        private void nEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double SecondNumber = Convert.ToDouble(txtBox.Text);
                double Result = 0;

                if (Operation == "+")
                {
                    Result = FirstNumber + SecondNumber;
                }
                else if (Operation == "-")
                {
                    Result = FirstNumber - SecondNumber;
                }
                else if (Operation == "*")
                {
                    Result = FirstNumber * SecondNumber;
                }
                else if (Operation == "/")
                {
                    Result = FirstNumber / SecondNumber;
                }
                else if (Operation == "**")
                {
                    Result = Math.Pow(FirstNumber, SecondNumber);
                }
                else if (Operation == "%")
                {
                    Result = FirstNumber % SecondNumber;
                }
                txtBox.Text = Convert.ToString(Result);
            }
            catch
            {
                MessageBox.Show("somthing went wrong!", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void nClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
        }
    }
}
