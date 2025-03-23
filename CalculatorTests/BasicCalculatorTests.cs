using CalculatorLibrary;
using Xunit;

namespace CalculatorTests
{
    public class BasicCalculatorTests
    {
        [Fact]
        public void Add_AddsNumberToResult()
        {
            var calculator = new BasicCalculator();
            calculator.Add(10);
            Assert.Equal(10, calculator.result);
        }

        [Fact]
        public void Subtract_SubtractsNumberFromResult()
        {
            var calculator = new BasicCalculator();
            calculator.Add(10);
            calculator.Subtract(3);
            Assert.Equal(7, calculator.result);
        }

        [Fact]
        public void Add_MultipleOperations_ResultIsCorrect()
        {
            var calculator = new BasicCalculator();
            calculator.Add(5);
            calculator.Add(5);
            calculator.Subtract(3);
            Assert.Equal(7, calculator.result);
        }
    }
}
