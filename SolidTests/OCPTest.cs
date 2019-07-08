using System;
using System.Collections.Generic;
using OCP;
using OCP.Enums;
using OCP.RightWay;
using Xunit;
using Xunit.Abstractions;

namespace SolidTests
{
    public class OCPTest
    {
        private ITestOutputHelper Output { get; set; }
        public OCPTest(ITestOutputHelper output)
        {
            Output = output;
        }
        public IEnumerable<DeveloperReport> Developers
        {
            get
            {
                return new List<DeveloperReport>
                {
                    new DeveloperReport()
                    {
                        CarrerStatus = DeveloperCarrerStatus.Junior,
                        HourlyRate = 20,
                        Id = 1,
                        Name = "Mock Man",
                        TechStack = new Tech[] {Tech.CSharp},
                        WorkingHours = 8
                    },
                    new DeveloperReport()
                    {
                        CarrerStatus = DeveloperCarrerStatus.Mid,
                        HourlyRate = 30,
                        Id = 2,
                        Name = "Henrique Trianon de Moraes Souza",
                        TechStack = new Tech[] {Tech.CSharp, Tech.Javascript},
                        WorkingHours = 8
                    },
                    new DeveloperReport()
                    {
                        CarrerStatus = DeveloperCarrerStatus.Architect,
                        HourlyRate = 80,
                        Id = 3,
                        Name = "The Ultra Master Dev",
                        TechStack = new Tech[] {Tech.CSharp, Tech.Javascript, Tech.Delphi, Tech.JAVA},
                        WorkingHours = 8
                    }
                };
            }
        }

        [Fact]
        public void OcpWrongWayTest()
        {
            var filter = new OCP.WrongWay.DeveloperReportFilter();
            var architects = filter.FilterByType(Developers, DeveloperCarrerStatus.Architect);
            foreach (var developerReport in architects)
            {
                Output.WriteLine(developerReport.Name);
            }
            var cSharpDevelopers = filter.FilterByTechStack(Developers, Tech.CSharp);
            foreach (var cSharpDeveloper in cSharpDevelopers)
            {
                Output.WriteLine($"Csharp Developer - {cSharpDeveloper}");
            }
        }

        [Fact]
        public void OcpRightWayTest()
        {
            var filter = new DeveloperReportFilter();
            var architects = filter.Filter(Developers,new DeveloperStatusSpecification(DeveloperCarrerStatus.Architect));
            foreach (var developerReport in architects)
            {
                Output.WriteLine($"Architect - {developerReport.Name}");
            }
            var cSharpDevelopers = filter.Filter(Developers, new DeveloperTechStackSpecification(Tech.CSharp));
            foreach (var cSharpDeveloper in cSharpDevelopers)
            {
                Output.WriteLine($"Csharp Developer - {cSharpDeveloper.Name}");
            }
        }
    }
}
