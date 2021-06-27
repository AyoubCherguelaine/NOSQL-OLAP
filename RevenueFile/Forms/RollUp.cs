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
    public partial class RollUp : Form
    {
        public RollUp()
        {
            InitializeComponent();
        }

        private void RollUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RollUpSelectProduit roll = new RollUpSelectProduit();
            roll.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RollUpSelectCutomer x = new RollUpSelectCutomer();
            x.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RollUpSelectTime z = new RollUpSelectTime();
            z.Show();
            this.Close();
        }
    }
}
