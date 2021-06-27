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
    public partial class DrillDownSelectCustomer : Form
    {
        public DrillDownSelectCustomer()
        {
            InitializeComponent();
        }

        string select = "";

        private void button1_Click(object sender, EventArgs e)
        {
            select = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select = "City";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(select != "")
            {
                if (select == "Name")
                {
                    // Name
                    DownloadData.Roll["Customer"] = "Name";
                    FunctionTree.Roll();
                }
                else
                {
                    //City
                    DownloadData.Roll["Customer"] = "City";
                    FunctionTree.Roll();
                }
            }
        }

        private void DrillDownSelectCustomer_Load(object sender, EventArgs e)
        {
            if(DownloadData.Roll["Customer"] == "Name")
            {
                button1.Visible = false;

                button2.Visible = false;
            }
            else
            {
                if (DownloadData.Roll["Customer"] == "City")
                {
                    button2.Visible = false;
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
