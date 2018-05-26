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
            //var sim = Simulation.Simulate(1080);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var statistic = Simulation.Simulate(Convert.ToDouble(FullTimeTextBox.Text));
            PeopleCountTextBox.Text = statistic.PeopleCount.ToString();
            MiddleTimeInQueveTextBox.Text = Math.Round(statistic.MiddleInQueueTime, 2).ToString();
            MiddleTimeInPhase1TextBox.Text = Math.Round(statistic.MiddlePhase1Time, 2).ToString();
            MiddleTimeInPhase2TextBox.Text = Math.Round(statistic.MiddlePhase2Time, 2).ToString();
        }
    }
}