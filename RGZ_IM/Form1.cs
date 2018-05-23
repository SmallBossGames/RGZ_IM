﻿using System;
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
            MiddleTimeInQueveTextBox.Text = statistic.MiddleInQueueTime.ToString();
            MiddleTimeInPhase1TextBox.Text = statistic.MiddlePhase1Time.ToString();
            MiddleTimeInPhase2TextBox.Text = statistic.MiddlePhase2Time.ToString();
        }
    }
}