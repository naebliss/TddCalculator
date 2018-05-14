using System;
using System.Text;

namespace Calculator
{
    public class TddCalculator
    {
        private double _total;

        private readonly ICalculationFormatter _formatter;

        public TddCalculator(int initialValue = 0)
        {
            _total = initialValue;
            _formatter = new CalculationFormatter(initialValue);
        }

        public double Add(double value)
        {
            _total += value;
            _formatter.AddCalculation("+", value, _total);
            return _total;
        }

        public double Subtract(double value)
        {
            _total -= value;
            _formatter.AddCalculation("-", value, _total);
            return _total;
        }

        public double Multiply(double value)
        {
            _total *= value;
            _formatter.AddCalculation("*", value, _total);
            return _total;
        }

        public double Divide(double value)
        {
            if (value.Equals(default(double)))
                throw new Exception("cannot divide by zero");

            _total = _total / value;
            _formatter.AddCalculation("/", value, _total);
            return _total;
        }

        public string Calculate()
        {
            return _formatter.Format();
        }
    }
}