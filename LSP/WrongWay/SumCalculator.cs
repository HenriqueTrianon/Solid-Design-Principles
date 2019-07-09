using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.WrongWay
{
    public class SumCalculator
    {
        protected IEnumerable<int> Numbers { get; }

        public SumCalculator(IEnumerable<int> numbers)
        {
            Numbers = numbers;
        }

        public virtual int Calculate() => Numbers.Sum();
    }
}
