using System;
using System.Collections;
using System.Collections.Generic;

namespace RGZ_IM
{
    class Flow : IQuest
    {
        private readonly List<Statistic.Human> flows = new List<Statistic.Human>();
        private readonly int criticalQueueSize;
        private readonly int defaultCount;
        private readonly int waveCount;
        private readonly int extremalCount;

        private Wave wave;
        private InputQueue inputQueue;
        private Statistic statistic;

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

        public void Init(Wave wave, InputQueue inputQueue, Statistic statistic)
        {
            this.statistic = statistic;
            this.wave = wave;
            this.inputQueue = inputQueue;
        }

        public double EndTime { get; private set; } = -1.0;

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public bool ToWork(double timeScale)
        {
            if ((flows.Count >= FreeFlowsCount) || (inputQueue.QueueLength == 0)) return false;

            while((flows.Count < FreeFlowsCount) && (inputQueue.QueueLength > 0))
            {
                var human = inputQueue.Dequeue();
                human.SetEndTime(timeScale);
                flows.Add(human);
            }

            flows.Sort();
            
            EndTime = flows[0].EndTime;

            Console.WriteLine($"{flows.Count} {FreeFlowsCount}");
            return true;
        }

        public bool TryMake(double timeScale)
        {
            if (EndTime < 0) return false;

            statistic.AddStatistic(flows[0]);
            flows.RemoveAt(0);
            EndTime = (flows.Count == 0) ? -1 : flows[0].EndTime;
            ToWork(timeScale);

            return true;
        }
    }

    class FlowAlterantive : IQuest
    {
        private readonly ChannelList channelList;
        private readonly int criticalQueueSize;
        private readonly int defaultCount;
        private readonly int waveCount;
        private readonly int extremalCount;

        private Wave wave;
        private InputQueue inputQueue;
        private Statistic statistic;

        private double lastAccessTime = 0.0;

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

        public FlowAlterantive(int criticalQueueSize, int defaultCount, int waveCount, int extremalCount)
        {
            this.criticalQueueSize = criticalQueueSize;
            this.defaultCount = defaultCount;
            this.waveCount = waveCount;
            this.extremalCount = extremalCount;
            channelList = new ChannelList(extremalCount);
        }

        public void Init(Wave wave, InputQueue inputQueue, Statistic statistic)
        {
            this.statistic = statistic;
            this.wave = wave;
            this.inputQueue = inputQueue;
            statistic.Flows = channelList.GetChannels;
        }

        public double EndTime => channelList.First.EndTime;

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public bool ToWork(double timeScale)
        {
            var deltaTime = timeScale - lastAccessTime;
            lastAccessTime = timeScale;
            channelList.UpdateStatus(deltaTime, FreeFlowsCount);

            if (!channelList.IsFreePlaceExist) return false;

            while (inputQueue.QueueLength > 0 && channelList.IsFreePlaceExist)
            {
                var humanPool = inputQueue.Dequeue();
                humanPool.SetEndTime(timeScale);
                channelList.TryPushData(humanPool);
            }
                

            return true;
        }

        public bool TryMake(double timeScale)
        {
            if (!channelList.TryPopData(out var pool)) return false;

            statistic.AddStatistic(pool);
            ToWork(timeScale);

            return true;
        }
    }


    class ChannelList
    {
        readonly Statistic.Channel[] channels;
        readonly int maxCapacity;

        int capacity = 0;

        public int Count { get; private set; }

        public bool IsFreePlaceExist => (capacity > Count);

        public Statistic.Channel First => channels[0];

        public IReadOnlyCollection<Statistic.IReadOnlyChannel> GetChannels =>
            Array.AsReadOnly<Statistic.IReadOnlyChannel>(channels);

        public ChannelList(int maxCapacity)
        {
            this.maxCapacity = maxCapacity;
            channels = new Statistic.Channel[maxCapacity];

            for (int i = 0; i < maxCapacity; i++)
                channels[i] = new Statistic.Channel();
        }

        public bool TryPushData(Statistic.Human human)
        {
            if (Count >= capacity)
                return false;

            channels[Count].PushHuman(human);
            Count++;
            Array.Sort(channels);
            return true;
        }

        public bool TryPopData(out Statistic.Human human)
        {
            if (!channels[0].IsWork) { human = null; return false; }

            human = channels[0].PopHuman();
            Count--;
            Array.Sort(channels);
            return true;
        }

        public void UpdateStatus(double deltaTime, int capacity)
        {
            if (capacity > maxCapacity || capacity < 0) throw new Exception("Wrong capacity");

            this.capacity = capacity;

            for (int i = 0; i < maxCapacity; i++)
            {
                var isActive = (i < capacity) ? true : false;
                channels[i].UpdateStatus(deltaTime, isActive);
            }
        }
    }
}