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
    public partial class RollUpSelectProduit : Form
    {
        public RollUpSelectProduit()
        {
            InitializeComponent();
        }
        string select = "";

        private void button4_Click(object sender, EventArgs e)
        {
            if (select != "")
            {

                DownloadData.Roll["Product"] = "Category";

                FunctionTree.Roll();
            }

        }

        private void RollUpSelectProduit_Load(object sender, EventArgs e)
        {
            if(DownloadData.Roll["Product"] == "Category")
            {
                button4.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select = "Category";
        }
    }
}
