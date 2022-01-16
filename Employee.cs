using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    class Employee
    {
        public Employee(string name, string surename, int age, int position, 
            string teleNick, Dictionary<DateTime, List<TimeSpan>> history)
        {
            this.name = name;
            this.surename = surename;
            this.age = age;
            this.position = position;
            this.teleNick = teleNick;
            this.history = history;
        }

        public Employee(string name, string surename, int age, int position, string teleNick)
        {
            this.name = name;
            this.surename = surename;
            this.age = age;
            this.position = position;
            this.teleNick = teleNick;
            this.history = new Dictionary<DateTime, List<TimeSpan>>();
        }

        public string name { get; set; }
        public string surename { get; set; }
        public int age { get; set; }
        public int position { get; set; }
        public string teleNick { get; set; }
        public Dictionary<DateTime, List<TimeSpan>> history { get; set; }
        
        public object[] toGrid()
        {
            object[] result = new object[] { name, surename, age, Util.empPostions[position], teleNick };
            return result;
        }
    }
}
