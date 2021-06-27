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
    public partial class DrillDownProduct : Form
    {
        public DrillDownProduct()
        {
            InitializeComponent();
        }

        private void DrillDownProduct_Load(object sender, EventArgs e)
        {
            if(DownloadData.Roll["Product"] == "Category")
            {

            }
            else
            {
                this.button1.Visible = false;
            }
        }

        string select = "";


        private void button1_Click(object sender, EventArgs e)
        {
            select = "ProductName";

        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (select !="")
            {
                DownloadData.Roll["Product"] = select;
                FunctionTree.Roll();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
