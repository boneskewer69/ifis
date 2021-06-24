namespace Freitag.Interfaces.Interfaces
{
    public interface ICalculator
    {
        string OperationName { get; }
        string Operator { get; }
        int Calculate(int a, int b);
    }
}
