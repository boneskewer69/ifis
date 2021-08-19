using System.Collections.Generic;

using Freitag.Interfaces.Interfaces;

namespace Freitag.Interfaces.Calculators
{
    public class Subtract : ICalculator
    {
        public string OperationName => "Subtract";

        public string Operator => "-";

        public int Calculate(int a, int b)
        {
            return a + b;
        }

        public void Foo()
        {
            System.Console.WriteLine("Foobar");
        }
    }
}
