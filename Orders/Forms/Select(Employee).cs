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
    public partial class Select_Employee_ : Form
    {
        public Select_Employee_()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        
        }
        string selected;
        private void button1_Click(object sender, EventArgs e)
        {
            //all
            selected = "All";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //city
            selected = "City";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //country
            selected = "Country";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //next
            if (selected != "All")
            {
                GetData.CubeOrders = new DataOrders(GetData.CubeOrders.axes);
                GetData.mode = "Roll_UP";
                GetData.query[0] = "Employee";
                GetData.query[1] = selected;
                GetData.GetdataDB();
            }
          
        }
    }
}
