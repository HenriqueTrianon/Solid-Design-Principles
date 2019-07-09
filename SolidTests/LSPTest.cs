using System.Collections.Generic;
using LSP.RightWay;
using Xunit;
using Xunit.Abstractions;

namespace SolidTests
{
    public class LSPTest
    {
        private ITestOutputHelper Output { get; }
        private IEnumerable<int> Numbers { get; } = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public LSPTest(ITestOutputHelper output)
        {
            Output = output;
        }
        [Fact]
        public void LCPWrongWayTest()
        {
            var calculator = new LSP.WrongWay.SumCalculator(Numbers);
            Assert.Equal(55, calculator.Calculate());
            calculator = new LSP.WrongWay.EvenSumCalculator(Numbers);
            Assert.Equal(36, calculator.Calculate());
        }

        [Fact]
        public void LCPRightWayTest()
        {
            ICalculator calculator = new SumCalculator(Numbers);
            Assert.Equal(55, calculator.calculate());
            calculator = new EvenSumCalculator(Numbers);
            Assert.Equal(36, calculator.calculate());
        }
    }
}
