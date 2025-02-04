namespace CalculatorAssignment
{
    internal class Addition : ICalculatorFunction
    {
        public string Operation(float num1, float num2)
        {

            return (num1 + num2).ToString();
        }

    }
}
