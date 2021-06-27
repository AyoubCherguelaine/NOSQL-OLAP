using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal.Orders
{
    public  class DataOrders
    {
        public int num;
        public List<string> axes= new List<string>();
        public Dictionary<string, Dictionary<string, Dictionary<string, Orders>>> Cube = new Dictionary<string, Dictionary<string, Dictionary<string, Orders>>>();
        public DataOrders(List<string> axes)
        {

            if (axes[0] == "Cutomer")
            {

                if (axes[1] == "Employee")
                {
                    // Cutomer Employee Time
                    num = 3;
                    
                }
                else
                {
                    // cutomer Time Employee
                    num = 4;
                }
            }
            else
            {
                if (axes[0] == "Employee")
                {
                    if (axes[1] == "Cutomer")
                    {
                        // Employee Cutomer Time
                        num = 2;
                    }
                    else
                    {
                        // Employee Time Cutomer
                        num = 1;
                    }
                }
                else
                {
                    if (axes[1] == "Employee")
                    {
                        //time Employee Cutomer
                        num = 5;
                    }
                    else
                    {
                        //time Cutomer Employee
                        num = 6;

                    }
                }

            }
        }
        private int OrdersUploading=0;
        public void addOrders(Orders O)
        {
            switch (num)
            {
                case 1: addOrders1(O);break;
                case 2: addOrders1(O); break;
                case 3: addOrders1(O); break;
                case 4: addOrders1(O); break;
                case 5: addOrders1(O); break;
                case 6: addOrders1(O); break;
              
            }

        }
        public event EventHandler FinishUploading;

        private void Check()
        {
            if(OrdersUploading == 40)
            {
                if(FinishUploading != null)
                {
                    FinishUploading(null, null);
                }
            }
        }

        private void addOrders1(Orders o)
        {

            // Employee Time Cutomer

            string EmpID = o.employee.ID;
            string CustID = o.customer.ID;
            string TimeID = o.time.ID;


            if (Cube.ContainsKey(EmpID))
            {
                if (Cube[EmpID].ContainsKey(TimeID))
                {
                    if (Cube[EmpID][TimeID].ContainsKey(CustID))
                    {
                        // .error
                        Cube[EmpID][TimeID][CustID] = o;
                    }
                    else
                    {
                        Cube[EmpID][TimeID].Add(CustID, o);
                    }
                }
                else
                {
                    Dictionary<string, Orders> x = new Dictionary<string, Orders>();
                    x.Add(CustID, o);

                    Cube[EmpID].Add(TimeID, x);

                }
            }
            else
            {
                Dictionary<string, Dictionary<string, Orders>> x = new Dictionary<string, Dictionary<string, Orders>>();
                Dictionary<string, Orders> y = new Dictionary<string, Orders>();
                y.Add(CustID, o);
                x.Add(TimeID, y);
                Cube.Add(EmpID, x);
            }
            

            this.OrdersUploading++;
            Check();
        }
        
        public void addOrders1RollUp(Orders o, string TD,string value)
        {
            string EmpID = o.employee.ID;
            string CustID = o.customer.ID;
            string TimeID = o.time.ID;
            if (TD == "Employee")
            {
                if(value == "City")
                {
                    EmpID = o.employee.City;
                }
                else
                {
                    EmpID = o.employee.Country;
                }
            }
            else
            {
                if(TD == "Time")
                {
                    TimeID =Convert.ToString( o.time.Year);

                }
                else
                {
                    if (value == "City")
                    {
                        CustID = o.employee.City;
                    }
                    else
                    {
                        CustID = o.employee.Country;
                    }
                }
            }

            if (Cube.ContainsKey(EmpID))
            {
                if (Cube[EmpID].ContainsKey(TimeID))
                {
                    if (Cube[EmpID][TimeID].ContainsKey(CustID))
                    {
                        // .error

                        Cube[EmpID][TimeID][CustID].NB_NO_Ship+=o.NB_NO_Ship;
                        Cube[EmpID][TimeID][CustID].NB_Ship += o.NB_Ship;

                    }
                    else
                    {
                        Cube[EmpID][TimeID].Add(CustID, o);
                    }
                }
                else
                {
                    Dictionary<string, Orders> x = new Dictionary<string, Orders>();
                    x.Add(CustID, o);

                    Cube[EmpID].Add(TimeID, x);

                }
            }
            else
            {
                Dictionary<string, Dictionary<string, Orders>> x = new Dictionary<string, Dictionary<string, Orders>>();
                Dictionary<string, Orders> y = new Dictionary<string, Orders>();
                y.Add(CustID, o);
                x.Add(TimeID, y);
                Cube.Add(EmpID, x);
            }


            this.OrdersUploading++;
            Check();
        }

        private void addOrdersGeneral(Orders o)
        {
            string f, s, t;
            if (this.axes[0] == "Employee")
            {
                f = o.employee.ID;
            }
            else
            {
                if (this.axes[0] == "Time")
                {
                    f = o.time.ID;
                }
                else
                {
                    f = o.customer.ID;
                }
            }


            if (this.axes[1] == "Employee")
            {
                s = o.employee.ID;
            }
            else
            {
                if (this.axes[1] == "Time")
                {
                    s = o.time.ID;
                }
                else
                {
                    s = o.customer.ID;
                }
            }
            if (this.axes[2] == "Employee")
            {
                t = o.employee.ID;
            }
            else
            {
                if (this.axes[2] == "Time")
                {
                    t = o.time.ID;
                }
                else
                {
                    t = o.customer.ID;
                }
            }


            if (Cube.ContainsKey(f))
            {
                if (Cube[f].ContainsKey(s))
                {
                    if (Cube[f][s].ContainsKey(t))
                    {
                        // .error
                        Cube[f][s][t] = o;
                    }
                    else
                    {
                        Cube[f][s].Add(t, o);
                    }
                }
                else
                {
                    Dictionary<string, Orders> x = new Dictionary<string, Orders>();
                    x.Add(t, o);

                    Cube[f].Add(s, x);

                }
            }
            else
            {
                Dictionary<string, Dictionary<string, Orders>> x = new Dictionary<string, Dictionary<string, Orders>>();
                Dictionary<string, Orders> y = new Dictionary<string, Orders>();
                y.Add(t, o);
                x.Add(s, y);
                Cube.Add(f, x);
            }


            this.OrdersUploading++;
            Check();

        }

    }
}
