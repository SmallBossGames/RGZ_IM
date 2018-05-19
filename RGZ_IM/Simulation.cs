using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_IM
{
    static class Simulation
    {
        public static Statistic Simulate(double fullTime)
        {
            var timeScale = 0.0;

            IQuest[] quests = { new InputQueue(), new Flow() };

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

            throw new NotImplementedException();
        }

    }

    class Statistic
    {
        public class Human
        {
            public double CreateTime { get; private set; }

            public Human(double createTime)
            {
                CreateTime = createTime;
            }
        }
    }

    class InputQueue : IQuest
    {
        private Wave wave;

        private readonly Queue<Statistic.Human> queue = new Queue<Statistic.Human>();

        public void Init(Wave wave)
        {
            this.wave = wave;
        }

        public InputQueue()
        {
            EndTime = SimaulationUtility.GetNextPeopleTime(false);
        }

        public double EndTime { get; private set; }

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public bool TryMake(double timeScale)
        {
            EndTime = timeScale + SimaulationUtility.GetNextPeopleTime(wave.IsWave);
            AddPeople(timeScale, SimaulationUtility.GetNextPeopleCount(wave.IsWave));
            return true;
        }

        private void AddPeople(double timeScale, int count)
        {
            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(new Statistic.Human(timeScale));
            }
        }
    }

    class Wave : IQuest
    {
        public bool IsWave { get; private set; }

        public double EndTime { get; private set; }

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public bool TryMake(double timeScale)
        {
            if (IsWave)
            {
                IsWave = false;
                EndTime = timeScale + SimaulationUtility.GetWave();
            }
            else
            {
                IsWave = true;
                EndTime = timeScale + SimaulationUtility.GetWaveLength();
            }
            return true;
        }
    }

    class Flow : IQuest
    {
        public double EndTime { get; private set; }

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public bool TryMake(double timeScale)
        {
            throw new NotImplementedException();
        }
    }

    interface IQuest : IComparable<IQuest>
    {
        double EndTime { get; }
        bool TryMake(double timeScale);
    }
}