using OCP.Enums;
using OCP.RightWay.Interfaces;

namespace OCP.RightWay
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
