using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OLAPFinal.Orders.Forms;
namespace OLAPFinal.Orders
{
    public partial class OrdersUI : UserControl
    {
        DataOrders Cube = new DataOrders(new List<string>() { "Employee", "Time","Cutomer" });
        public OrdersUI()
        {
            InitializeComponent();
        }

        public string Roll="General";

        private void changeRoll(object args,EventArgs e)
        {
            Roll = Convert.ToString(args);

            Chemin.Text += " :" + Roll;
        }

        void ShowDataOrders(int index)
        {
            if (index >= 0)
            {
                string id = GetIdBySelected(ListAxe1.Items[index].ToString());
                ShowDataTimeCustomer(id);
            }
        }
        int index;

        void ShowDataTimeCustomer(string idEMP)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Customer");

            foreach ( string time in GetData.CubeOrders.Cube[idEMP].Keys.ToArray())
            {
                dataTable.Columns.Add(time);
            }

            foreach (string time in GetData.CubeOrders.Cube[idEMP].Keys.ToArray())
            {
                foreach(string cust in GetData.CubeOrders.Cube[idEMP][time].Keys.ToArray())
                {
                    bool isHere = false;

                    foreach(DataRow row in dataTable.Rows)
                    {
                        if ( this.GetIdBySelected(  row["Customer"].ToString()) ==  cust)
                        {
                            isHere = true;
                            int i = dataTable.Rows.IndexOf(row);
                            int maj = GetData.CubeOrders.Cube[idEMP][time][cust].NB_NO_Ship + GetData.CubeOrders.Cube[idEMP][time][cust].NB_Ship;
                            dataTable.Rows[i][time] = Convert.ToString(maj);
                            break;
                        }
                    
                    }
                    if (!isHere)
                    {
                        DataRow x = dataTable.NewRow();
                        x["Customer"] = cust+": "+ GetData.CubeOrders.Cube[idEMP][time][cust].customer.Name;
                        
                        int maj = GetData.CubeOrders.Cube[idEMP][time][cust].NB_NO_Ship + GetData.CubeOrders.Cube[idEMP][time][cust].NB_Ship;

                        x[time] = Convert.ToString(maj);
                        dataTable.Rows.Add(x);
                    }
                }
            }

            DataCube.DataSource = dataTable;

        }


        public void timecutomerDrill(string idEMP ,string arg)
        {
           
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Customer");

            foreach (string time in GetData.CubeOrders.Cube[idEMP].Keys.ToArray())
            {
                dataTable.Columns.Add(time);
            }

            foreach (string time in GetData.CubeOrders.Cube[idEMP].Keys.ToArray())
            {
                foreach (string cust in GetData.CubeOrders.Cube[idEMP][time].Keys.ToArray())
                {
                    bool isHere = false;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (this.GetIdBySelected(row["Customer"].ToString()) == cust)
                        {
                            isHere = true;
                            int i = dataTable.Rows.IndexOf(row);
                                int maj;
                            if (arg == "NB_NO_Ship")
                                maj = GetData.CubeOrders.Cube[idEMP][time][cust].NB_NO_Ship;
                            else
                                maj = GetData.CubeOrders.Cube[idEMP][time][cust].NB_Ship;
                            dataTable.Rows[i][time] = Convert.ToString(maj);
                            break;
                        }

                    }
                    if (!isHere)
                    {
                        DataRow x = dataTable.NewRow();
                        x["Customer"] = cust + ": " + GetData.CubeOrders.Cube[idEMP][time][cust].customer.Name;
                        int maj;
                        if (arg == "NB_NO_Ship")
                            maj = GetData.CubeOrders.Cube[idEMP][time][cust].NB_NO_Ship;
                        else
                            maj = GetData.CubeOrders.Cube[idEMP][time][cust].NB_Ship;
                        x[time] = Convert.ToString(maj);
                        dataTable.Rows.Add(x);
                    }
                }
            }
            DataCube.DataSource = dataTable;
        }


        private void Roll_UP_Click(object sender, EventArgs e)
        {
            RollUP roll = new RollUP();
            roll.Show();

        }

        

        private void Drill_Down_Click(object sender, EventArgs e)
        {
            Forms.Drill_Down drill = new Drill_Down(Roll);
            drill.Show();
        }

        private void Slice_Click(object sender, EventArgs e)
        {
            Forms.Slice slice = new Slice();
            slice.Show();
        }

        private void Dice_Click(object sender, EventArgs e)
        {

        }

        string GetIdBySelected(string item)
        {
            string id = "";
            foreach(char c in item)
            {
                if (c != ':')
                    id += c;
                else
                    break;
            }
            return id;
        }

        void ShowEmployeeAxe1()
        {


            foreach (string EmpID in GetData.CubeOrders.Cube.Keys.ToArray())
            {
                string id2, id3;
                id2 = GetData.CubeOrders.Cube[EmpID].Keys.ToArray()[0];
                id3 = GetData.CubeOrders.Cube[EmpID][id2].Keys.ToArray()[0];
                Orders test=   GetData.CubeOrders.Cube[EmpID][id2][id3];

                ListAxe1.Invoke(new MethodInvoker(delegate {
                    ListAxe1.Items.Add(test.employee.ID + ": " + test.employee.Firstname + " " + test.employee.Lastname);
                }));

               

            }
       
        }
        void ShowCustomerAxe1()
        {


            foreach (string CustID in GetData.CubeOrders.Cube.Keys.ToArray())
            {
                string id2, id3;
                id2 = GetData.CubeOrders.Cube[CustID].Keys.ToArray()[0];
                id3 = GetData.CubeOrders.Cube[CustID][id2].Keys.ToArray()[0];
                Orders test = GetData.CubeOrders.Cube[CustID][id2][id3];
                ListAxe1.Items.Add(test.customer.ID + ": " + test.customer.Name);

            }
        }
    
        void ShowTimeAxe1()
        {


            foreach (string time in GetData.CubeOrders.Cube.Keys.ToArray())
            {
                string id2, id3;
                id2 = GetData.CubeOrders.Cube[time].Keys.ToArray()[0];
                id3 = GetData.CubeOrders.Cube[time][id2].Keys.ToArray()[0];
                Orders test = GetData.CubeOrders.Cube[time][id2][id3];
                ListAxe1.Items.Add(test.time.ID);

            }
        }


        void UploadAxe1()
        {
            ShowEmployeeAxe1();
            if (Axe1.InvokeRequired)
            {
                Axe1.Invoke(new MethodInvoker(delegate { Axe1.Text = "Employee"; }));
            }
            if (Chemin.InvokeRequired)
            {
                Chemin.Invoke(new MethodInvoker(delegate { Chemin.Text = "/Time/Employee"; }));
            }

          
          
        }


        void GetDataAxe1(object  o, EventArgs e )
        {
            if (CheckIF())
            {
                Console.WriteLine("Finish uploading \n num orders :" + GetData.idsNumber);
                UploadAxe1();
            }
        }
        bool CheckIF()
        {
            return GetData.t.IsCompleted;
        }

        private void OrdersUI_Load(object sender, EventArgs e)
        {
            GetData.CubeOrders.FinishUploading += GetDataAxe1;
            GetData.changeDrill += changeRoll;
        }

        
        private void ListAxe1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click");
            index = ListAxe1.SelectedIndex;
            if(Roll=="General")
            ShowDataOrders(index);
            else
            {
                timecutomerDrill( GetIdBySelected(ListAxe1.Items[index].ToString()) , Roll);
            }
        }

        private void DataCube_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
