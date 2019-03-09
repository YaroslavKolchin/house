using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public enum position
    {
        manager,
        worker
    }
    public interface IWorker
    {
        int id { get; set; }
        string fullName { get; set; }
        double salary { get; set; }
        position position { get; set; }
        void printInfo();
        double CalculateSalary(TimeSpan t);
    }
}
