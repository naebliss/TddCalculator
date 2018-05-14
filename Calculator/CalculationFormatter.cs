using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculationFormatter : ICalculationFormatter
    {
        private readonly int _initialValue;
        private readonly List<Calculation> _calculations = new List<Calculation>();

        public CalculationFormatter(int initialValue)
        {
            _initialValue = initialValue;
        }

        public void AddCalculation(string operation, double value, double newTotal)
        {
            _calculations.Add(new Calculation
            {
                Operation = operation,
                Value = value,
                NewTotal = newTotal
            });
        }

        public string Format()
        {
            const int width = 10;
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"{_initialValue:F0}".PadLeft(width));

            for (int i = 0; i < _calculations.Count; i++)
            {
                var calc = _calculations[i];
                sb.AppendLine($"{calc.Operation}{calc.Value:F0}".PadLeft(width));
                sb.AppendLine(new string('-', width));
                bool isLastEntry = i == _calculations.Count -1;
                sb.AppendLine(isLastEntry
                    ? $"total  {calc.NewTotal:F1}"
                    : $"sub    {calc.NewTotal.ToString("##.##").PadLeft(3)}");
            }

            return sb.ToString();
        }
    }

    public class Calculation
    {
        public string Operation { get; set; }
        public double Value { get; set; }
        public double NewTotal { get; set; }
    }
}