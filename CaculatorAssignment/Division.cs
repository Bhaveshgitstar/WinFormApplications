namespace CalculatorAssignment
{
    public class Division : ICalculatorFunction
    {
        public string Operation(float num1, float num2)
        {
            if (num2 != 0)
            {

                return (num1 / num2).ToString();
            }
            else
            {
                return "Division by zero";
            }

        }
    }
}
