using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLAPFinal.Orders.Forms
{
    public partial class Select_Customer_ : Form
    {
        string SelectButton = "";

        public Select_Customer_()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectButton = "All";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SelectButton = "City";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SelectButton = "Country";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SelectButton != "")
            {
                Opperation opperation = new Opperation();
                opperation.Show();
            }
        }
    }
}
