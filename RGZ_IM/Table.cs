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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        public void AddData(int j, double workTime, double activeTime, double procent)
        {
            TableOfChannels.Rows.Add(j, Math.Round(workTime, 2), Math.Round(activeTime, 2), Math.Round(procent, 2));
        }
    }
}