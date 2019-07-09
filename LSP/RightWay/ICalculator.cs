using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.RightWay
{
    public interface ICalculator
    {
        IEnumerable<int> Numbers { get; }
        int calculate();
    }
}
