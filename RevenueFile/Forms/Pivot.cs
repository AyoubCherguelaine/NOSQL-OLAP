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
    public partial class Pivot : Form
    {
        public Pivot()
        {
            InitializeComponent();
            Axes.Add("Customer",false);
            Axes.Add("Product", false);
            Axes.Add("Time", false);
            
        }

        Dictionary<string, bool> Axes = new Dictionary<string, bool>();
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pivot_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string k in Axes.Keys.ToArray())
            {

                if (Axes[k] == false)
                {
                    comboBox1.Items.Add(k);
                }
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            l = comboBox3.SelectedItem.ToString();
            Axes[l] = true;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            foreach (string k in Axes.Keys.ToArray())
            {

                if (Axes[k] == false)
                {
                    comboBox3.Items.Add(k);
                }
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (string k in Axes.Keys.ToArray())
            {

                if (Axes[k] == false)
                {
                    comboBox2.Items.Add(k);
                }
            }
        }

        string f, s, l;

        private void button1_Click(object sender, EventArgs e)
        {
            if (f != s && s != l && l != f)
            {
                DownloadData.axes[0] = f;
                DownloadData.axes[1] = s;
                DownloadData.axes[2] = l;
                FunctionTree.Roll();
              //  Close();
            }
        }

        private void check()
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select first
            f = comboBox1.SelectedItem.ToString();
            Axes[f] = true;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select scnd
            s = comboBox2.SelectedItem.ToString();
            Axes[s] = true;
        }
    }
}
