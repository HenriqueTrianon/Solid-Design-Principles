using OpenClosedPrinciple.Enums;

namespace OpenClosedPrinciple
{
    public class DeveloperReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeveloperCarrerStatus CarrerStatus { get; set; }
        public Tech[] TechStack { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
