namespace largest_of_three_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                
                double[] number = { Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text) };
                if (number[0] > number[1] && number[0] > number[2])
                {
                    label1.Text = "Largest";
                }
                else if (number[1] > number[0] && number[1] > number[2])
                {
                    label2.Text = "Largest";
                }
                else
                {
                    label3.Text = "Largest";
                }
                
            }
            catch
            {
               label1.Text="Fill it";
                label2.Text = "Fill it";
                label3.Text = "Fill it";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

        }
    }
}