using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class TddCalculatorSpecs
    {
        /// <summary>
        /// the calculator should have a add method that adds the result to the current total returns the total
        /// </summary>
        public class Add
        {
            [Fact]
            public void Should_add_value_to_total()
            {
            }

            [Fact]
            public void Should_add_two_values_together()
            {
            }
        }

        /// <summary>
        /// the calculator should have a subtract method that subtracts the result from the current total returns the total
        /// </summary>
        public class Subtract
        {
            [Fact]
            public void Should_subtract_value_from_total()
            {
            }

            [Fact]
            public void Should_subtract_two_values()
            {
            }
        }

        /// <summary>
        /// the calculator should have a multiply method that multiplies the current total and returns the total
        /// </summary>
        public class Multiply
        {
            [Fact]
            public void Should_multiply_total_with_given_value()
            {
            }
        }

        /// <summary>
        /// the calculator should have a divide method that divides the current total and returns the total 
        /// the calculator should throw a exception with the text 'cannot divide by zero' when a divide by zero exception occurs
        /// </summary>
        public class Divide
        {
            [Fact]
            public void Should_divide_total_by_given_value()
            {
            }

            [Fact]
            public void Should_throw_exception_for_divide_by_zero_error()
            {
            }
        }

        /// <summary>
        /// the calculator should have a calculate function that returns a formatted string with all subtotals and the endresult
        /// </summary>
        public class Calculate
        {
            [Fact]
            public void Should_return_formatted_result()
            {
                var expected = new StringBuilder();
                expected.AppendLine("         1");
                expected.AppendLine("        +4");
                expected.AppendLine("        -2");
                expected.AppendLine("        *3");
                expected.AppendLine("        /2");
                expected.AppendLine("        +1");
                expected.AppendLine("----------");
                expected.AppendLine("total  5,5");






            }
        }
    }
}
