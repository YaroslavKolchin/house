using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Model
{
    class TeamLeader : IWorker
    {
        public string fullName { get; set; }
        public double salary { get; set; }
        public position position { get; set; }
        public List<ITask> tasks;
        public double CalculateSalary(TimeSpan t)
        {
            return t.TotalHours * salary*1.05;
        }
        public void printInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fullname {0} ({1}) ", fullName, position);
            Console.WriteLine("Ставка: {0:0,000 KZT}", salary);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
