using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_IM
{
    static class Simulation
    {
        public static Statistic Simulate(double fullTime, SimulationUtility utility)
        {
            var flow = new FlowAlterantive(15);
            var queue = new InputQueue();
            var wave = new Wave();
            var statistic = new Statistic();

            flow.Init(wave, queue, statistic, utility);
            queue.Init(wave, flow, utility, statistic);
            wave.Init(flow, utility);

            var timeScale = 0.0;

            IQuest[] quests = { flow, queue, wave };

            while (timeScale < fullTime)
            {
                Array.Sort(quests);
                for (int i = 0; i < quests.Length; i++)
                {
                    if (quests[i].EndTime > timeScale)
                        timeScale = quests[i].EndTime;

                    if (quests[i].TryMake(timeScale)) break;
                }
            }
            return statistic;
        }
    }

    interface IQuest : IComparable<IQuest>
    {
        double EndTime { get; }
        bool TryMake(double timeScale);
    }
}