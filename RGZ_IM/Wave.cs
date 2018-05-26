namespace RGZ_IM
{
    class Wave : IQuest
    {
        private FlowAlterantive flow;
        private SimulationUtility utility;

        public bool IsWave { get; private set; }

        public double EndTime { get; private set; }

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public Wave()
        {
            
        }

        public void Init(FlowAlterantive flow, SimulationUtility utility)
        {
            this.utility = utility;
            this.flow = flow;

            IsWave = false;
            EndTime = utility.GetWave();
        }

        public bool TryMake(double timeScale)
        {
            if (IsWave)
            {
                IsWave = false;
                EndTime = timeScale + utility.GetWave();
            }
            else
            {
                IsWave = true;
                EndTime = timeScale + utility.GetWaveLength();
            }

            flow.ToWork(timeScale);
            return true;
        }
    }
}