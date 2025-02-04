using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorAssignment
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent2();
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            OnLoad();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "8");
        }

        private void AllClearButton_Click(object sender, EventArgs e)
        {
            OnAllClear();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            OnClear();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "9");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

            Utility.OutputMiddleware(ref historyListBox, ref resultList, ref DisplayScreenBottom, ref DisplayScreenTop, division, publisher, ref _number1, ref _number2, "/", ref _isResult, ref result);

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {

            Utility.OutputMiddleware(ref historyListBox, ref resultList, ref DisplayScreenBottom, ref DisplayScreenTop, multiplication, publisher, ref _number1, ref _number2, "x", ref _isResult, ref result);

        }

        private void SubstractionButton_Click(object sender, EventArgs e)
        {

            Utility.OutputMiddleware(ref historyListBox, ref resultList, ref DisplayScreenBottom, ref DisplayScreenTop, subtraction, publisher, ref _number1, ref _number2, "-", ref _isResult, ref result);

        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {

            Utility.OutputMiddleware(ref historyListBox, ref resultList, ref DisplayScreenBottom, ref DisplayScreenTop, addition, publisher, ref _number1, ref _number2, "+", ref _isResult, ref result);

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            Utility.ResultHandler(ref historyListBox, ref resultList, ref DisplayScreenBottom, ref DisplayScreenTop, publisher, ref _number1, ref _number2, ref _isResult, ref result);

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "3");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "2");

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "1");

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            ZeroInputHandler();
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            DecimalHandler();
        }

        private void UnaryOperationButton_Click(object sender, EventArgs e)
        {
            UnaryHandler();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "7");

        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "4");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "6");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "5");
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            Utility.OutputMiddleware(ref historyListBox, ref resultList, ref DisplayScreenBottom, ref DisplayScreenTop, percentage, publisher, ref _number1, ref _number2, "%", ref _isResult, ref result);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            GetHistory();
        }

        private void GetHistory()
        {
            if (_isHistoryOpen)
            {
                _isHistoryOpen = false;
                this.Size = new Size(255, 346);
            }
            else
            {
                _isHistoryOpen = true;
                this.Size = new Size(500, 346);
            }
        }

        private void OnAllClear()
        {
            DisplayScreenBottom.Text = "";
            DisplayScreenTop.Text = "";
        }

        private void OnClear()
        {
            DisplayScreenBottom.Text = "";
        }

        private void ZeroInputHandler()
        {

            if (DisplayScreenBottom.Text != "0")
            {
                Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, "0");

            }
            else
            {
                DisplayScreenBottom.Text = "0";
            }

        }

        private void DecimalHandler()
        {
            if (_countDecimal == 0)
            {
                _countDecimal = 1;
                Utility.InputMiddleware(ref DisplayScreenBottom, ref _isResult, ".");
            }
        }

        private void UnaryHandler()
        {
            if (!String.IsNullOrEmpty(DisplayScreenBottom.Text))
            {
                if (_unaryOperator == "+")
                {
                    _unaryOperator = "-";
                    DisplayScreenBottom.Text = _unaryOperator + DisplayScreenBottom.Text;

                }
                else
                {
                    _unaryOperator = "+";
                    DisplayScreenBottom.Text = DisplayScreenBottom.Text.Substring(1, DisplayScreenBottom.Text.Length - 1);
                }
            }
            else
            {
                MessageBox.Show("Invalid Operation");
            }
        }
    }

    public class Publisher
    {
        public delegate string MyDelegate(float x, float y);
        public MyDelegate calculatorFunctions;
    }

}
