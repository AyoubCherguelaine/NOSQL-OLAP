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
    public partial class RollUP : Form
    {
        string ButtonSelected = "";

        public RollUP()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RollUP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ButtonSelected = "Employee";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ButtonSelected = "Customer";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ButtonSelected = "Time";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(ButtonSelected != "")
            {
                if(ButtonSelected == "Employee")
                {
                    Select_Employee_ select_Employee_ = new Select_Employee_();
                    select_Employee_.Show();
                    this.Close();
                }
                else
                {
                    if (ButtonSelected == "Customer")
                    {
                        Select_Customer_ select_Customer_ = new Select_Customer_();
                        select_Customer_.Show();
                        Close();
                    }
                    else
                    {
                        Select_Time_ select_Time_ = new Select_Time_();
                        select_Time_.Show();
                        Close();
                    }
                }
            }
        }
    }
}
