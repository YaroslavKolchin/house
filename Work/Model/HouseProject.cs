using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Model
{
    class HouseProject
    {
        public HouseProject()
        {
            this.createProject();
            this.team.createTeam(); 
            this.createProject();
        }
        
        List<IPart> parts = new List<IPart>();
        List<ITask> tasks = new List<ITask>();
        Team team = new Team();

        private Random rnd = new Random();
        private void createProject()
        {
            Basement basement = new Basement()
            {
                countPart = 1,
                price = rnd.Next(1000000, 2000000),
                partName = "Basement",
                order = 0
            };
            Roof roof = new Roof()
            {
                countPart = 1,
                price = rnd.Next(100000, 200000),
                partName = "Roof",
                order = 0
            };
            Walls walls = new Walls()
            {
                countPart = rnd.Next(4, 12),
                price = rnd.Next(500000, 1000000),
                partName = "Walls",
                order = 0
            };
            parts.Add(basement);
            parts.Add(roof);
            parts.Add(walls);
        }
        private void CreateTasks()
        {
            foreach (IPart part in parts.OrderBy(o => o.order))
            {
                for (int i = 0; i < part.countPart; i++)
                {
                    Task task = new Task();
                    task.part = part;
                    tasks.Add(task);
                }
            }
        }
        public void startBuilding()
        {
            int workersCount = team.team.Count();
            IWorker worker = team.team[rnd.Next(0, workersCount)];
            ITask task = getUnifinishedTask();
            if (task != null)
            {
                tasks[task.Id].Status = status.complete;
                tasks[task.Id].Worker = team.getFreeWorker();
                tasks[task.Id].Begin = DateTime.Now;
                tasks[task.Id].End = DateTime.Now.AddDays(120);
            }
            Console.WriteLine("Работы по строительству завершены");
        }
        public ITask getUnifinishedTask()
        {
            return tasks.OrderBy(o => o.Part.order).Where(w => w.Status == status.create).FirstOrDefault();
        }
    }
}
