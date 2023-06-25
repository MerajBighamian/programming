using static System.Net.Mime.MediaTypeNames;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnReset(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtSymbol.Text = string.Empty;
            lblResult.Text = string.Empty;
        }


        private void btnCalculate(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNum1.Text);
            double number2 = Convert.ToDouble(txtNum2.Text);
            double answer;


            if (txtNum1.Text != string.Empty)
            {
                if (txtNum2.Text != string.Empty)
                {
                    if (txtSymbol.Text != string.Empty)
                    {
                        if (txtSymbol.Text == "+")
                        {
                            double sum = number1 + number2;
                            string result = sum.ToString();
                            result = " = " + result;
                            lblResult.Text = result;
                        }
                        else if (txtSymbol.Text == "-")
                        {
                            double mines = number1 - number2;
                            string result = mines.ToString();
                            result = " = " + result;
                            lblResult.Text = result;
                        }

                        else if (txtSymbol.Text == "*")
                        {
                            double multiply = number1 * number2;
                            string result = multiply.ToString();
                            result = " = " + result;
                            lblResult.Text = result;
                        }
                        else if (txtSymbol.Text == "/")
                        {
                            double divide = number1 / number2;
                            string result = divide.ToString();
                            result = " = " + result;
                            lblResult.Text = result;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Symbol!", "Error Symbol!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Number 2!", "Error Number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Number 1!", "Error Number!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}