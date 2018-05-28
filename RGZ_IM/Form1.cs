using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_IM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double itCount = 0;
            var utility = new SimulationUtility(Convert.ToDouble(NextPeopleTimeTextBox.Text), Convert.ToDouble(NextPeopleTimeTextBox.Text) / 2, Convert.ToDouble(NextWaveTimeTextBox.Text), Convert.ToDouble(WaveTimeTextBox.Text), Convert.ToDouble(MiddleServiceTimeTextBox.Text), Convert.ToDouble(MiddleServiceWaveTimeTextBox.Text), Convert.ToDouble(OrderTimeTextBox.Text));
            int peopleCount = 0;
            double MiddleInQueue = 0;
            double MiddleInPhase1Time = 0;
            double MiddleInPhase2Time = 0;
            double InWorkTime = 0;
            double ActiveTime = 0;

            itCount = WriteData(utility);

            for (int i = 0; i < itCount; i++)
            {
                var statistic = Simulation.Simulate(Convert.ToDouble(FullTimeTextBox.Text), utility);
                peopleCount += statistic.PeopleCount;
                MiddleInQueue += statistic.MiddleInQueueTime;
                MiddleInPhase1Time += statistic.MiddlePhase1Time;
                MiddleInPhase2Time += statistic.MiddlePhase2Time;

                foreach (var a in statistic.Flows)
                {
                    InWorkTime += a.InWorkTime;
                    ActiveTime += a.ActiveTime;
                }
            }

            IterationCountTextBox.Text = itCount.ToString();
            PeopleCountTextBox.Text = Math.Round((peopleCount / itCount), 2).ToString();
            MiddleTimeInQueveTextBox.Text = Math.Round((MiddleInQueue / itCount), 2).ToString();
            MiddleTimeInPhase1TextBox.Text = Math.Round((MiddleInPhase1Time / itCount), 2).ToString();
            MiddleTimeInPhase2TextBox.Text = Math.Round((MiddleInPhase2Time / itCount), 2).ToString();
            ChannelsMiddleTimeWorkTextBox.Text = Math.Round((InWorkTime / itCount), 2).ToString();
            ChannelMiddleTimeTextBox.Text = Math.Round((ActiveTime / itCount), 2).ToString();
        }

        double WriteData(SimulationUtility utility)
        {
            const int itCount = 50;

            double accuracy = Convert.ToDouble(AccuracyTextBox.Text);
            double kvantil = Convert.ToDouble(KvantilTextBox.Text);
            double middleInQueueTime = 0;
            double dispersion = 0;
            double itCountFinal = 0;

            double[] middleInQueueTimeS = new double[itCount];

            for (int i = 0; i < itCount; i++)
            {
                var statistic = Simulation.Simulate(Convert.ToDouble(FullTimeTextBox.Text), utility);
                var middle = statistic.MiddleInQueueTime;
                middleInQueueTimeS[i] = middle;
                middleInQueueTime += middle / itCount;
            }

            for (int i = 0; i < itCount; i++) dispersion += (middleInQueueTimeS[i] * middleInQueueTimeS[i] - middleInQueueTime * middleInQueueTime);

            dispersion /= itCount - 1;

            itCountFinal = Math.Ceiling(dispersion * dispersion * kvantil * kvantil / (accuracy * accuracy));

            return itCountFinal;
        }
    }
}