using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.WrongWay
{
    public class SumCalculator
    {
        protected int[] Numbers { get; }

        public SumCalculator(int[] numbers)
        {
            Numbers = numbers;
        }

        public virtual int Calculate() => Numbers.Sum();
    }
}
