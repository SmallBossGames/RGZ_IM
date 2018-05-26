namespace RGZ_IM
{
    class Wave : IQuest
    {
        private FlowAlterantive flow;

        public bool IsWave { get; private set; }

        public double EndTime { get; private set; }

        public int CompareTo(IQuest other) => EndTime.CompareTo(other.EndTime);

        public Wave()
        {
            IsWave = false;
            EndTime = SimulationUtility.GetWave();
        }

        public void Init(FlowAlterantive flow)
        {
            this.flow = flow;
        }

        public bool TryMake(double timeScale)
        {
            if (IsWave)
            {
                IsWave = false;
                EndTime = timeScale + SimulationUtility.GetWave();
            }
            else
            {
                IsWave = true;
                EndTime = timeScale + SimulationUtility.GetWaveLength();
            }

            flow.ToWork(timeScale);
            return true;
        }
    }
}