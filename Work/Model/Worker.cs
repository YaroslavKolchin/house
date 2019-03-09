using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Model
{
    public class Worker : IWorker
    {
        public Worker(position worker)
        {
            tasks = new List<ITask>();
            this.position = position;
        }
        public string fullName { get; set; }
        public double salary { get; set; }
        public position position { get; set; }
        public List<ITask> tasks;
        public double CalculateSalary(TimeSpan t)
        {
            return t.TotalHours * salary;
        }
        public void printInfo()
        {
            Console.WriteLine("Fullname {0} ({1}) ", fullName, position);
        }
    }
}
