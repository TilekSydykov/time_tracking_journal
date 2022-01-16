using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    class Util
    {
        public static string[] empPostions = { "dir", "smm", "hr", "dev" };

        public static Employee[] employeesExample =
        {
            new Employee("Tilek", "Sydykov", 22, 0, "@hgknk", new Dictionary<DateTime, List<TimeSpan>>(){
                { DateTime.Today.Date, new List<TimeSpan>()
                {
                    new TimeSpan(8, 0, 0),
                    new TimeSpan(10, 30, 0),
                    new TimeSpan(11, 0, 0),
                    new TimeSpan(12, 10, 0),
                    new TimeSpan(12, 15, 0),
                    new TimeSpan(13, 30, 0),
                    new TimeSpan(14, 30, 0),
                    new TimeSpan(18, 15, 0)
                } }
            }),
            new Employee("Doslan", "Zheksheev", 21, 3, "@DosU13"),
            new Employee("Askhat", "Askarov", 21, 3, "@DemoAst"),
            new Employee("Nurbol", "Chorobaev", 22, 2, "@chorobaev")
        };
    }
}
