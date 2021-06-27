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
    public partial class DrillDown : Form
    {
        public DrillDown()
        {
            InitializeComponent();
        }

        string select = "";
        private void button1_Click(object sender, EventArgs e)
        {
            select = "Product";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select = "Customer";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            select = "Time";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(select == "Product")
            {

                DrillDownProduct  x= new DrillDownProduct();
                x.Show();
                this.Close();

            }
            else
            {
                if(select == "Customer")
                {
                    DrillDownSelectCustomer x = new DrillDownSelectCustomer();
                    x.Show();
                    this.Close();
                }
                else
                {
                    if(select == "Time")
                    {
                        DrillDownSelectTime x = new DrillDownSelectTime();
                        x.Show();
                        this.Close();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
