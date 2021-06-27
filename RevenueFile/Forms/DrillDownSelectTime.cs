using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLAPFinal.RevenueFile.Forms
{
    public partial class DrillDownSelectTime : Form
    {
        public DrillDownSelectTime()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool x = false;
        private void button1_Click(object sender, EventArgs e)
        {
            x = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x)
            {
                DownloadData.Roll["Time"] = "Month";
                FunctionTree.Roll();
            }
        }

        private void DrillDownSelectTime_Load(object sender, EventArgs e)
        {
            if(DownloadData.Roll["Time"] == "Month")
            {
                button1.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
