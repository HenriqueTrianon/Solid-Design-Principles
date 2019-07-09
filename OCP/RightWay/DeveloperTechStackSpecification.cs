using System.Linq;
using OCP.Enums;
using OCP.RightWay.Interfaces;

namespace OCP.RightWay
{
    public class DeveloperTechStackSpecification:ISpecification<DeveloperReport>
    {
        public Tech[] TechStack { get; }
        public DeveloperTechStackSpecification(params Tech[] techStack)
        {
            TechStack = techStack;
        }
        public bool IsSatisfied(DeveloperReport item) => TechStack.All(ts => item.TechStack.Contains(ts));
    }
}
