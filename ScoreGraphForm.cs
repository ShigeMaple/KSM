using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KSM
{
    public partial class ScoreGraphForm : Form
    {
        public ScoreGraphForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void TestGrapgh()
        {
            Series seriesLine = new Series();
            seriesLine.ChartType = SeriesChartType.Line;
        }
    }
}
