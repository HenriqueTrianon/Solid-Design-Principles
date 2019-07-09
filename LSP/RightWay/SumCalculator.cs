using System.Collections.Generic;
using System.Linq;

namespace LSP.RightWay
{
    public class SumCalculator : ICalculator
    {
        public IEnumerable<int> Numbers { get; }
        public SumCalculator(IEnumerable<int> numbers)
        {
            Numbers = numbers;
        }
        public int calculate() => Numbers.Sum();
    }
}
