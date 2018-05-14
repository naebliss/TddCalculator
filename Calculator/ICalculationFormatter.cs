namespace Calculator
{
    public interface ICalculationFormatter
    {
        void AddCalculation(string operation, double value, double newTotal);
        string Format();
    }
}