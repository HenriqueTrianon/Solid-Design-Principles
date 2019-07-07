using OpenClosedPrinciple.Enums;
using OpenClosedPrinciple.RightWay.Interfaces;

namespace OpenClosedPrinciple.RightWay
{
    public class DeveloperStatusSpecification : ISpecification<DeveloperReport>
    {
        private DeveloperCarrerStatus Status { get; }

        public DeveloperStatusSpecification(DeveloperCarrerStatus status)
        {
            Status = status;
        }
        public bool IsSatisfied(DeveloperReport item) => item.CarrerStatus == Status;
    }
}
