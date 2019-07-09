using System.Collections.Generic;
using System.Linq;

namespace LSP.RightWay
{
    public class EvenSumCalculator: ICalculator
    {
        public IEnumerable<int> Numbers { get; }
        public EvenSumCalculator(IEnumerable<int> numbers)
        {
            Numbers = numbers;
        }
        public int calculate() => Numbers.Where(x => x % 2 == 0).Sum();
    }
}
