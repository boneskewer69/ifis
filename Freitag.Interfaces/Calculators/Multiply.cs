using Freitag.Interfaces.Interfaces;

namespace Freitag.Interfaces.Calculators
{
    public class Multiply : ICalculator
    {
        public string OperationName => "Multiply";
        public string Operator => "*";

        public int Calculate(int a, int b)
        {
            return a * b;
        }
    }
}
