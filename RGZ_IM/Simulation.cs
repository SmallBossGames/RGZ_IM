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
            var flow = new Flow(15, 5, 6, 7);
            var queue = new InputQueue();
            var wave = new Wave();

            flow.Init(wave, queue);
            queue.Init(wave, flow);
            wave.Init(flow);

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

            return new Statistic();
        }

    }

    class Statistic
    {
        public class Human
        {
            public double CreateTime { get; private set; }

            public double ServiceTime { get; private set; }

            public double EndTime { get; private set; }

            public void SetEndTime(double timeScale)
            {
                EndTime = timeScale + ServiceTime;
            }

            public Human(double createTime, double serviceTime)
            {
                CreateTime = createTime;
                ServiceTime = serviceTime;
            }
        }
    }

    class InputQueue : IQuest
    {
        private Wave wave;
        private Flow flow;

        private readonly Queue<Statistic.Human> queue = new Queue<Statistic.Human>();

        public int QueueLength => queue.Count;

        public void Init(Wave wave, Flow flow)
        {
            this.wave = wave;
            this.flow = flow;
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
            flow.ToWork(timeScale);
            return true;
        }

        public Statistic.Human Dequeue() => queue.Dequeue();

        private void AddPeople(double timeScale, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var serviceTime = SimaulationUtility.GetServiceTime();
                queue.Enqueue(new Statistic.Human(timeScale, serviceTime));
            }
        }
    }

    class Wave : IQuest
    {
        private Flow flow;

        public bool IsWave { get; private set; }

        public double EndTime { get; private set; }

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public void Init(Flow flow)
        {
            this.flow = flow;
        }

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

            flow.ToWork(timeScale);
            return true;
        }
    }

    class Flow : IQuest
    {
        private readonly List<Statistic.Human> flows = new List<Statistic.Human>();
        private readonly int criticalQueueSize;
        private readonly int defaultCount;
        private readonly int waveCount;
        private readonly int extremalCount;

        private Wave wave;
        private InputQueue inputQueue;

        private int FreeFlowsCount
        {
            get
            {
                var retValue = defaultCount;
                if (wave.IsWave) retValue = waveCount;
                if (inputQueue.QueueLength > criticalQueueSize) retValue = extremalCount;
                return retValue;
            }
        }

        public Flow(int criticalQueueSize, int defaultCount, int waveCount, int extremalCount)
        {
            this.criticalQueueSize = criticalQueueSize;
            this.defaultCount = defaultCount;
            this.waveCount = waveCount;
            this.extremalCount = extremalCount;
        }

        public void Init(Wave wave, InputQueue inputQueue)
        {
            this.wave = wave;
            this.inputQueue = inputQueue;
        }

        public double EndTime { get; private set; } = -1.0;

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public bool ToWork(double timeScale)
        {
            if ((flows.Count >= FreeFlowsCount) || (inputQueue.QueueLength == 0)) return false;

            while((flows.Count < FreeFlowsCount) || (inputQueue.QueueLength > 0))
            {
                var human = inputQueue.Dequeue();
                human.SetEndTime(timeScale);
                flows.Add(human);
            }

            flows.Sort();

            EndTime = flows[0].EndTime;

            return true;
        }

        public bool TryMake(double timeScale)
        {
            if (EndTime < 0) return false;

            flows.RemoveAt(0);
            EndTime = (flows.Count == 0) ? -1 : flows[0].EndTime;
            ToWork(timeScale);

            return true;
        }
    }

    interface IQuest : IComparable<IQuest>
    {
        double EndTime { get; }
        bool TryMake(double timeScale);
    }
}