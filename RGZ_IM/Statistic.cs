using System;
using System.Collections.Generic;

namespace RGZ_IM
{
    class Statistic
    {

        private double phase1Time;
        private double phase2Time;
        private double inQueueTime;

        public int PeopleCount { get; private set; }

        public int FullPeopleCount { get; private set; }

        public IReadOnlyCollection<IReadOnlyChannel> Flows { get; set; }

        public double MiddlePhase1Time => phase1Time / PeopleCount;

        public double MiddlePhase2Time => phase2Time / PeopleCount;

        public double MiddleInQueueTime => inQueueTime / PeopleCount;
 

        public Statistic()
        {
            phase1Time = 0.0;
            phase2Time = 0.0;
            inQueueTime = 0.0;
            FullPeopleCount = 0;
            PeopleCount = 0;
        }

        public void IncFullPeopleCount() => FullPeopleCount++;

        public void AddStatistic(Human human)
        {
            var inQueue = human.EndTime - human.CreateTime - human.ServiceTimePhase1;

            PeopleCount++;
            inQueueTime += inQueue;
            phase1Time += human.ServiceTimePhase1;
            phase2Time += human.ServiceTimePhase2;
        }

        public interface IReadOnlyChannel
        {
            double InWorkTime { get; }

            double ActiveTime { get; }
        }

        public class Channel : IReadOnlyChannel, IComparable<Channel>
        {
            public Human humanData = null;

            public bool IsActive { get; private set; } = false;

            public bool IsWork => humanData != null;

            public double InWorkTime { get; private set; } = 0.0;

            public double ActiveTime { get; private set; } = 0.0;

            public double EndTime => humanData == null ? Double.MaxValue : humanData.EndTime;

            public void PushHuman(Human data)
            {
                if ((humanData != null)||(!IsActive))
                    throw new Exception("Incorrect change object");

                humanData = data;   
            }

            public Human PopHuman()
            {
                if (humanData == null)
                    throw new Exception("Incorrect change object");

                var pool = humanData;
                humanData = null;
                return pool;
            }

            public void UpdateStatus(double deltaTime, bool isActive)
            {
                if (!IsWork) IsActive = isActive;
                if (IsActive) ActiveTime += deltaTime;
                if (IsWork) InWorkTime += deltaTime;
            }

            public int CompareTo(Channel other) => EndTime.CompareTo(other.EndTime);
        }



        public class Human:IComparable<Human>
        {
            public double CreateTime { get; private set; }

            public double ServiceTimePhase1 { get; private set; }

            public double ServiceTimePhase2 { get; private set; }

            public double EndTime { get; private set; }

            public void SetEndTime(double timeScale)
            {
                EndTime = timeScale + ServiceTimePhase1;
            }

            public int CompareTo(Human other)
            {
                return EndTime.CompareTo(other.EndTime);
            }

            public Human(double createTime, double serviceTimePhase1, double serviceTimePhase2)
            {
                CreateTime = createTime;
                ServiceTimePhase1 = serviceTimePhase1;
                ServiceTimePhase2 = serviceTimePhase2;
            }
        }
    }
}