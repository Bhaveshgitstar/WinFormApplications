namespace CalculatorAssignment
{
    internal class Percentage : ICalculatorFunction
    {
        public string Operation(float num1, float num2)
        {
            return (num1 * num2 * 0.01).ToString();
        }
    }
}
