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
    public partial class Drill_Down : Form
    {
        public Drill_Down(string Drill)
        {
            InitializeComponent();
            if(Drill == "General")
            {

            }
            else
            {
                if (Drill == button2.Text)
                {
                    button2.Text = "General";
                }
                else
                {
                    button3.Text = "General";
                }
            }
        }

        string selected = "";
        private void button2_Click(object sender, EventArgs e)
        {
            selected = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Drill Down :" + selected);
            GetData.changeDrillFunction(selected);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Drill_Down_Load(object sender, EventArgs e)
        {

        }
    }
}
