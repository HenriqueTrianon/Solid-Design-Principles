using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenClosedPrinciple.Enums;
using OpenClosedPrinciple.RightWay.Interfaces;

namespace OpenClosedPrinciple.RightWay
{
    public class DeveloperTechStackSpecification:ISpecification<DeveloperReport>
    {
        public Tech[] TechStack { get; }
        public DeveloperTechStackSpecification(Tech[] techStack)
        {
            TechStack = techStack;
        }
        public bool IsSatisfied(DeveloperReport item) => TechStack.All(ts => item.TechStack.Contains(ts));
    }
}
