using System;
using System.Windows.Forms;

namespace FormAssignment2
{
    public partial class DivisibilityChecker : Form
    {
        public DivisibilityChecker()
        {
            InitializeComponent();
        }

        private void backButtonForm3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void closeButtonForm3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkDivible(long dividend, long divisor)
        {
            string message = "";
            if (dividend % divisor == 0)
            {
                message = dividend + " is divisible by " + divisor;
            }
            else
            {
                message = dividend + " is not divisible by " + divisor;
            }
            MessageBox.Show(message);
        }
        private void divisibilitycheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(dividendInput.Text) && !String.IsNullOrEmpty(divisorInput.Text))
                {
                    long dividend = long.Parse(dividendInput.Text);
                    long divisor = long.Parse(divisorInput.Text);
                    checkDivible(dividend, divisor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetFields_Click(object sender, EventArgs e)
        {
            dividendInput.Text = divisorInput.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
