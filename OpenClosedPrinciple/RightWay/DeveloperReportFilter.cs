using System.Collections.Generic;
using System.Linq;
using OpenClosedPrinciple.RightWay.Interfaces;

namespace OpenClosedPrinciple.RightWay
{
    public class DeveloperReportFilter : IFilter<DeveloperReport>
    {
        public List<DeveloperReport> Filter(IEnumerable<DeveloperReport> monitors, ISpecification<DeveloperReport> specification) =>
            monitors.Where(m => specification.IsSatisfied(m)).ToList();
    }
}
