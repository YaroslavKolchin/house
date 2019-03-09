using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser;

namespace Work.Model
{
    class Team
    {
        public List<IWorker> team = new List<IWorker>();
        private Random rnd = new Random();
        public void createTeam()
        {
            var user = GenerateUser.GetUser();
            TeamLeader teamLeader = new TeamLeader();
            teamLeader.fullName = user.name.title + user.name.first;
            teamLeader.salary = rnd.Next(3000, 10000);

            for (int i = 0; i < rnd.Next(3, 20); i++)
            {
                user = GenerateUser.GetUser();
                Worker worker = new Worker(position.worker);
                teamLeader.fullName = user.name.title + user.name.first;
                teamLeader.salary = rnd.Next(1000, 5000);
                team.Add(worker);
            }
        }
        public IWorker getFreeWorker()
        {
            return team[rnd.Next(0, workersCount)];
        }




    }
}
