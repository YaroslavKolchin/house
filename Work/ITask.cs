using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public enum status { create, process, complete }
    public interface ITask
    {
        DateTime Begin { get; set; }
        DateTime End { get; set; }
        status Status { get; set; }
        IWorker Worker { get; set; }
        IPart Part { get; set; }
        int Id { get; set; }
    }
}