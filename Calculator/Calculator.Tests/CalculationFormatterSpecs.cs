using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class CalculationFormatterSpecs
    {
        public class Format
        {
            [Fact]
            public void Should_return_formatted_result()
            {
                //arrange
                var expected = new StringBuilder();
                expected.AppendLine("         1");
                expected.AppendLine("        +4");
                expected.AppendLine("----------");
                expected.AppendLine("sub      5");
                expected.AppendLine("        -2");
                expected.AppendLine("----------");
                expected.AppendLine("sub      3");
                expected.AppendLine("        *3");
                expected.AppendLine("----------");
                expected.AppendLine("sub      9");
                expected.AppendLine("        /2");
                expected.AppendLine("----------");
                expected.AppendLine("sub    4,5");
                expected.AppendLine("        +1");
                expected.AppendLine("----------");
                expected.AppendLine("total  5,5");

                CalculationFormatter sut = new CalculationFormatter();
                sut.SetInitialValue(1);

                //act
                sut.AddCalculation("+", 4, 5);
                sut.AddCalculation("-", 2, 3);
                sut.AddCalculation("*", 3, 9);
                sut.AddCalculation("/", 2, 4.5);
                sut.AddCalculation("+", 1, 5.5);

                string actual = sut.Format();

                //assert
                Assert.Equal(expected.ToString(), actual);
            }
        }
    }
}