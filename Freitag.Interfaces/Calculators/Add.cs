using Freitag.Interfaces.Interfaces;

namespace Freitag.Interfaces.Calculators
{
    public class Add : ICalculator
    {
        public string OperationName => "Add";
        public string Operator => "+";

        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
