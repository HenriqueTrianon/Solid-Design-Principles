using System.Collections.Generic;

namespace OCP.RightWay.Interfaces
{
    interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> developers, ISpecification<T> specification);
    }
}
