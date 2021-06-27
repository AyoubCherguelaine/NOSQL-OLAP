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
    public partial class RollUpSelectCutomer : Form
    {
        public RollUpSelectCutomer()
        {
            InitializeComponent();

            if(DownloadData.Roll["Customer"] == "Name")
            {

            }
            else
            {
                if(DownloadData.Roll["Customer"]== "City")
                {
                    button1.Visible = false;
                }
                else
                {
                    button1.Visible = false;
                    button2.Visible = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (select != "")
            {

                DownloadData.Roll["Customer"] = select;
                FunctionTree.Roll();

            }

        }

        string select = "";
        private void button1_Click(object sender, EventArgs e)
        {
            select = "City";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select = "Country";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
