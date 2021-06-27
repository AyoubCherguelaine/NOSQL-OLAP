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
    public partial class FormWelcome : Form
    {
        public FormWelcome(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
          
        }

       
       
    }
}
