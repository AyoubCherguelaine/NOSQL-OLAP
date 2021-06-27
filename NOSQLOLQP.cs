using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLAPFinal
{
    public partial class NOSQLOLQP : Form
    {
        public NOSQLOLQP()
        {
           InitializeComponent();
           
        }
       
        private void Stop_Screen(object o , EventArgs e)
        {
            this.Visible = false;
        }

        private void Start_Screen(object o , EventArgs e)
        {
            this.Visible = true;
        }
       public Orders.OrdersUI Orders = new Orders.OrdersUI();
        public RevenueFile.RevenueUI RevenueUI = new RevenueFile.RevenueUI();
        private void NOSQLOLQP_Load(object sender, EventArgs e)
        {
            FormInsert.createUserControl(Orders, "Orders", new Point(166, 36), this, 3);
            Begin.LoadingStart += deseble;
            Begin.LoadingFinish += Enable;
            RevenueFile.DownloadData.Reflesh += Reflesh;
            FormInsert.createUserControl(RevenueUI, "revenue", new Point(166, 36), this, 3);

        }

        void Reflesh(object o , EventArgs e)
        {
          //  Console.WriteLine("\n\n\nReflesh");
           // RevenueUI = null;
           // RevenueFile.RevenueUI eee = new RevenueFile.RevenueUI();

            //FormInsert.createUserControl(eee, "revenue", new Point(166, 36), this, 3);
        }

        void Enable(object o , EventArgs e)
        {
            this.Enabled = true;

        }
        void deseble(object o, EventArgs e)
        {
            this.Enabled = false;
        }

        void CloseApplication(object o , EventArgs e)
        {
            Close();
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            RevenueUI.Visible = false;
            Orders.Visible = true;
           
        }

        private void Revenue_Click(object sender, EventArgs e)
        {
            Orders.Visible = false;
            RevenueUI.Visible = true;

        }
    }

}
