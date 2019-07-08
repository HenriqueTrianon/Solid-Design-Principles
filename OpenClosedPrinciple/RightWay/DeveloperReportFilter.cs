using System.Collections.Generic;
using System.Linq;
using OCP.RightWay.Interfaces;

namespace OCP.RightWay
{
    public class DeveloperReportFilter : IFilter<DeveloperReport>
    {
        public IEnumerable<DeveloperReport> Filter(IEnumerable<DeveloperReport> developers, ISpecification<DeveloperReport> specification) =>
            developers.Where(m => specification.IsSatisfied(m));
    }
}
