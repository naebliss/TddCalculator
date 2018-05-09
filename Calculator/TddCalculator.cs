namespace Calculator
{
    public class TddCalculator
    {
        private double _total;

        public double Add(double value)
        {
            return _total += value;
        }
    }
}