using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace first_windows_form
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = text_Name.Text;
            string Family = text_Family.Text;
            string Age = text_Age.Text;
            string Address = text_Address.Text;

            if(Name != "")
            {
                if (Family !="")
                {
                    if(Age != "")
                    {
                        if(Address != "")
                        {
                            MessageBox.Show($"name is : {Name} and Family is : {Family} and Age is : {Age} and Address is :  {Address}");
                        }
                        else
                        {
                            MessageBox.Show("address is not valid");
                        }
                    }
                    else
                    {
                        MessageBox.Show("age is not valid");
                    }
                }
                else
                {
                    MessageBox.Show("family is not valid");
                }
                
            }
            else
            {
                MessageBox.Show("name is not valid");
            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}