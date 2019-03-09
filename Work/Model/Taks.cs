using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Model
{
    class Task : ITask
    {
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public status Status { get; set; }
        public IWorker Worker { get; set; }
        public IPart Part { get; set; }

        public void printInfo()
        {
            switch (Status)
            {
                case status.create:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-> ", Part.partName);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case status.process:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-> ", Part.partName);
                        Console.WriteLine("Начало: {0}", Begin);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case status.complete:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("-> ", Part.partName);
                        Console.WriteLine("Начало: {0}-{1}", Begin, End);
                        Worker.printInfo();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
            }
        }


       
    }
}
