﻿using System.Collections.Generic;

namespace RGZ_IM
{
    class InputQueue : IQuest
    {
        private Wave wave;
        private FlowAlterantive flow;
        private SimulationUtility utility;

        private readonly Queue<Statistic.Human> queue = new Queue<Statistic.Human>();

        public int QueueLength => queue.Count;

        public void Init(Wave wave, FlowAlterantive flow, SimulationUtility utility)
        {
            this.utility = utility;
            this.wave = wave;
            this.flow = flow;
            EndTime = utility.GetNextPeopleTime(false);
        }

        public InputQueue()
        {
            
        }

        public double EndTime { get; private set; }

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public bool TryMake(double timeScale)
        {
            EndTime = timeScale + utility.GetNextPeopleTime(wave.IsWave);
            AddPeople(timeScale, utility.GetNextPeopleCount(wave.IsWave));
            flow.ToWork(timeScale);
            return true;
        }

        public Statistic.Human Dequeue() => queue.Dequeue();

        private void AddPeople(double timeScale, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var orderTime = utility.GetOrderTime();
                var serviceTime = utility.GetServiceTime(timeScale);

                queue.Enqueue(new Statistic.Human(timeScale, orderTime, serviceTime));
            }
        }
    }
}