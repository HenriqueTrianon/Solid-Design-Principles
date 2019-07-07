using System.Collections.Generic;

namespace OpenClosedPrinciple.RightWay.Interfaces
{
    interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> enumerable, ISpecification<T> specification);
    }
}
