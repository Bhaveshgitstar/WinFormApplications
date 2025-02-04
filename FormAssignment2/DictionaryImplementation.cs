using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormAssignment2
{
    public partial class DictionaryImplementation : Form
    {
        public delegate void closeForms();

        // Step 2: Declare an event
        public event closeForms CloseForm2;
        public event closeForms CloseFormAll;


        private void backButtonForm2_Click(object sender, EventArgs e)
        {
            this.CloseForm2();
        }

        private void closeAllPrevious_Click(object sender, EventArgs e)
        {
            this.CloseFormAll();
        }


        // Method to raise the event
        //protected virtual void OnCloseForm2()
        //{
        //    if (OnCloseForm2 != null)
        //    {
        //        this.CloseForm2();
        //    }
        //}

        // Method to trigger the event

        public DictionaryImplementation()
        {
            InitializeComponent();
        }



        private void nextButtonForm2_Click(object sender, EventArgs e)
        {
            DivisibilityChecker form3 = new DivisibilityChecker();
            form3.ShowDialog();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        Dictionary<int, string> newDictionary = new Dictionary<int, string>();

        private void fetchValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(fetchKeyInput.Text))
                {
                    int key = Convert.ToInt32(fetchKeyInput.Text);
                    string message = "For Key : " + key + " Value is " + newDictionary[key];
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Please enter any key");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            keyInput.Text = "";
            valueInput.Text = "";
        }


        private void addNewItemDict_Click(object sender, EventArgs e)
        {

            try
            {
                if (!String.IsNullOrEmpty(keyInput.Text) && !String.IsNullOrEmpty(valueInput.Text))
                {
                    int key = Convert.ToInt32(keyInput.Text);
                    string value = valueInput.Text;
                    newDictionary.Add(key, value);
                    string message = "Pair " + key + ":" + value + " Added to Dictionary";
                    keyInput.Text = valueInput.Text = "";
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Please enter both fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void closeButtonForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
