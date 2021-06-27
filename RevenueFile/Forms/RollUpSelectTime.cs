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
    public partial class RollUpSelectTime : Form
    {
        public RollUpSelectTime()
        {
            InitializeComponent();

            if(DownloadData.Roll["Time"] == "Year")
            {
                button1.Visible = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (x)
            {
                DownloadData.Roll["Time"] = "Year";
                FunctionTree.Roll();
               // this.Close();

            }
        }

        bool x = false;

        private void button1_Click(object sender, EventArgs e)
        {
            x = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
