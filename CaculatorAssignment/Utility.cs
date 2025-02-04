using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorAssignment
{
    public class Utility
    {

        public static void Calculate(Publisher publisher, float num1, float num2, ref string result)
        {
            try
            {
                if (publisher.calculatorFunctions != null)
                {

                    result = publisher.calculatorFunctions(num1, num2);
                    publisher.calculatorFunctions = null;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public static void InputMiddleware(ref TextBox DisplayScreenBottom, ref bool isResult, string number)
        {
            try
            {
                if (isResult)
                {
                    DisplayScreenBottom.Text = number;
                    isResult = false;
                }
                else
                {
                    DisplayScreenBottom.Text += number;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public static void OutputMiddleware(ref ListBox historyListBox, ref List<string> list, ref TextBox DisplayScreenBottom, ref TextBox DisplayScreenTop, ICalculatorFunction operation, Publisher publisher, ref string _number1, ref string _number2, string Symbol, ref bool isResult, ref string result)
        {
            try
            {
                if (String.IsNullOrEmpty(DisplayScreenTop.Text))
                {
                    _number1 = DisplayScreenBottom.Text;
                    DisplayScreenTop.Text += DisplayScreenBottom.Text + Symbol; ;
                    publisher.calculatorFunctions = null;
                    publisher.calculatorFunctions = operation.Operation;
                    DisplayScreenBottom.Text = "";
                }
                else if (String.IsNullOrEmpty(DisplayScreenBottom.Text))
                {
                    publisher.calculatorFunctions = operation.Operation;
                    DisplayScreenTop.Text = _number1 + Symbol;

                }
                else
                {
                    _number2 = DisplayScreenBottom.Text;
                    Calculate(publisher, float.Parse(_number2), float.Parse(_number1), ref result);
                    DisplayScreenBottom.Text = result;
                    publisher.calculatorFunctions = operation.Operation;
                    _number1 = result.ToString();
                    DisplayScreenTop.Text = _number1 + Symbol;
                    isResult = true;
                    _number2 = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ResultHandler(ref ListBox historyListBox, ref List<string> list, ref TextBox DisplayScreenBottom, ref TextBox DisplayScreenTop, Publisher publisher, ref string _number1, ref string _number2, ref bool isResult, ref string result)
        {
            if (!String.IsNullOrEmpty(_number1))
            {
                _number2 = DisplayScreenBottom.Text;
                Utility.Calculate(publisher, float.Parse(_number1), float.Parse(_number2), ref result);
                DisplayScreenTop.Text = DisplayScreenTop.Text + _number2 + "=";
                list.Add(DisplayScreenTop.Text + result);
                historyListBox.DataSource = null;
                historyListBox.DataSource = list;
                _number1 = DisplayScreenBottom.Text = result;
                isResult = true;
                _number1 = _number2;
                _number2 = null;
                publisher.calculatorFunctions = null;
            }

        }


    }
}
