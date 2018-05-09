using System;
using System.Text;

namespace Calculator
{
    public class TddCalculator
    {
        private double _total;

        private const int calculationWidth = 10;
        private StringBuilder calculations = new StringBuilder();

        public TddCalculator(int initialValue = 0)
        {
            _total = initialValue;
            AddCalculation("",initialValue);
        }

        public double Add(double value)
        {
            AddCalculation("+", value);
            return _total += value;
        }

        public double Subtract(double value)
        {
            AddCalculation("-", value);
            return _total -= value;
        }

        public double Multiply(double value)
        {
            AddCalculation("*", value);
            return _total *= value;
        }

        public double Divide(double value)
        {
            if (value.Equals(default(double)))
                throw new Exception("cannot divide by zero");

            AddCalculation("/", value);
            return _total = _total / value;
        }

        public string Calculate()
        {
            calculations.AppendLine(new string('-', calculationWidth));
            calculations.AppendLine($"total  {_total:F1}");
            return calculations.ToString();
        }

        private void AddCalculation(string operation, double value)
        {
            calculations.AppendLine($"{operation}{value:F0}".PadLeft(calculationWidth));
        }
    }
}