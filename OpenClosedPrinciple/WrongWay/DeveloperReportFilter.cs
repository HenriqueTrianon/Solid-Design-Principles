using System.Collections.Generic;
using System.Linq;
using OpenClosedPrinciple.Enums;

namespace OpenClosedPrinciple.Filter
{
    class DeveloperReportFilter
    {
        public IEnumerable<DeveloperReport> FilterByType(IEnumerable<DeveloperReport> developers, DeveloperCarrerStatus status) =>
            developers.Where(m => m.CarrerStatus == status).ToList();
        // After a demand, the Project Manager decided to add a new Feature, to filter by tech stack, it would be wrong for the OCP standards to modify it directly as below.
        public IEnumerable<DeveloperReport> FilterByTechStack(IEnumerable<DeveloperReport> developers, Tech[] techStack) =>
            developers.Where(m => techStack.All(a => m.TechStack.Contains(a)));
    }
}
