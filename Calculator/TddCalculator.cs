using System;

namespace Calculator
{
    public class TddCalculator
    {
        private double _total;

        public TddCalculator(int initialValue = 0)
        {
            _total = initialValue;
        }

        public double Add(double value)
        {
            return _total += value;
        }

        public double Subtract(double value)
        {
            return _total -= value;
        }

        public double Multiply(double value)
        {
            return _total *= value;
        }

        public double Divide(double value)
        {
            if (value.Equals(default(double)))
                throw new Exception("cannot divide by zero");

            return _total / value;
        }
    }
}