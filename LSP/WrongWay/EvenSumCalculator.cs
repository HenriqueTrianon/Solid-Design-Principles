using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.WrongWay
{
    public class EvenSumCalculator:SumCalculator
    {
        public EvenSumCalculator(IEnumerable<int> numbers):base(numbers)
        {
            
        }
        public override int Calculate() => Numbers.Where(x => x % 2 == 0).Sum();
    }
}
