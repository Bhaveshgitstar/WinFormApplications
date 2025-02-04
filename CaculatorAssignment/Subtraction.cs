namespace CalculatorAssignment
{
    public class Subtraction : ICalculatorFunction
    {
        public string Operation(float num1, float num2)
        {

            return (num1 - num2).ToString();
        }
    }
}
