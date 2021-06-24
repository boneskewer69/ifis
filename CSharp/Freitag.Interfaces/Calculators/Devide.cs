using System.Collections.Generic;

using Freitag.Interfaces.Interfaces;

namespace Freitag.Interfaces.Calculators
{
    public class Devide : ICalculator
    {
        public string OperationName => "Devide";

        public string Operator => "/";

        public int Calculate(int a, int b)
        {
            return a / b;
        }
    }
}
