using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLAPFinal.RevenueFile
{
    public partial class RevenueUI : UserControl
    {
        public RevenueUI()
        {
            InitializeComponent();
        }

        private void RevenueUI_Load(object sender, EventArgs e)
        {
            Slice.Visible = false;
            Dice.Visible = false;
            DownloadData.finDownload += UploadData;
            DownloadData.Reflesh += Reflesh;
      
        }

        private void Reflesh(object o ,EventArgs e)
        {
            Console.WriteLine("Refleshh ya chkoopiii");

            ListAxe1.Items.Clear();

            uploadAxe1N();
        }

        private void uploadAxe1()
        {

            if (Axe1.InvokeRequired)
            {
                Axe1.Invoke(new MethodInvoker(delegate { Axe1.Text = DownloadData.axes[0] + "(" + DownloadData.Roll[DownloadData.axes[0]] + ")"; }));
            }
            if (Chemin.InvokeRequired)
            {
                Chemin.Invoke(new MethodInvoker( delegate {
                    Chemin.Text = $"{DownloadData.axes[1]}({DownloadData.Roll[DownloadData.axes[1]]})/{DownloadData.axes[2]}({DownloadData.Roll[DownloadData.axes[2]]})";
                }));
            }

            foreach(string name in DownloadData.Cube.Keys.ToArray())
            {
                if (ListAxe1.InvokeRequired)
                    ListAxe1.Invoke(new MethodInvoker(delegate
                    {
                        ListAxe1.Items.Add(name);
                    }));
            }

        }

        private void uploadAxe1N()
        {
                    Axe1.Text = DownloadData.axes[0] + "(" + DownloadData.Roll[DownloadData.axes[0]] + ")"; 
           
                    Chemin.Text = $"{DownloadData.axes[1]}({DownloadData.Roll[DownloadData.axes[1]]})/{DownloadData.axes[2]}({DownloadData.Roll[DownloadData.axes[2]]})";
              

            foreach (string name in DownloadData.Cube.Keys.ToArray())
            {
                
                        ListAxe1.Items.Add(name);
                    
            }
        }

        private double GetNuber(ArrayList List)
        {
            double value=0;

            if(DownloadData.Drill == "OrderRevenue")
            {
                foreach( Revenue r in List)
                {
                    value += r.OrderRevenue;
                }
            }
            else
            {
                foreach (Revenue r in List)
                {
                    value += r.ShippedRevenue;
                }
            }


            return value;
        }

        private void uploadDataGrid(string key1)
        {
            DataTable data1 = new DataTable() ;
            data1.Columns.Add(DownloadData.axes[2]);
            Dictionary<string, Dictionary<string, ArrayList>> x = DownloadData.Cube[key1];
            foreach(string key2 in x.Keys.ToArray())
            {
              if(!data1.Columns.Contains(key2))
                {
                    data1.Columns.Add(key2);
                }

                Dictionary<string, ArrayList> y = x[key2];
                foreach (string key3 in y.Keys.ToArray())
                {
                    double val = GetNuber(y[key3]);
                    int i = 0;
                    foreach( DataRow row in data1.Rows)
                    {
                        if(row[DownloadData.axes[2]].ToString() == key3)
                        {
                            data1.Rows[i][key2] =Convert.ToString( val);
                            val = -5;
                            break;
                        }
                        i++;
                    }
                    if(val!= -5)
                    {
                        DataRow row = data1.NewRow();
                        row[DownloadData.axes[2]] = key3;
                        row[key2] =Convert.ToString( val);
                        data1.Rows.Add(row);
                    }
                   
                }
            }
            DataCube.DataSource = data1;
            
        
        }

        private void UploadData(object o ,EventArgs we)
        {
            uploadAxe1();
            
        }

        private void ListAxe1_Click(object sender, EventArgs e)
        {
            int index = ListAxe1.SelectedIndex;
            if(index >=0 && index < ListAxe1.Items.Count)
            {
                uploadDataGrid(ListAxe1.Items[index].ToString());
            }
        }

        private void Roll_UP_Click(object sender, EventArgs e)
        {
            Forms.RollUp r = new Forms.RollUp();
            r.Show();
        }

        private void Drill_Down_Click(object sender, EventArgs e)
        {
            Forms.DrillDown dr = new Forms.DrillDown();
            dr.Show();

        }

        private void Dice_Click(object sender, EventArgs e)
        {

        }

        private void Slice_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DownloadData.Drill == "ShippedRevenue")
            {

                DownloadData.Drill = "OrderRevenue";
                button1.Text = "ShippedRevenue";
            }
            else
            {
                DownloadData.Drill = "ShippedRevenue";
                button1.Text = "OrderRevenue";
            }
            Reflesh(null, EventArgs.Empty);
        }

        private void Pivot_Click(object sender, EventArgs e)
        {
            Forms.Pivot x = new Forms.Pivot();
            x.Show();
        }
    }
}
