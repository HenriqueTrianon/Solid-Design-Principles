using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.RightWay
{
    interface ICalculator
    {
        IEnumerable<int> Numbers { get; }
        int calculate();
    }
}
