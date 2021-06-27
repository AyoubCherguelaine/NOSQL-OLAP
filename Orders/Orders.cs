 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace OLAPFinal.Orders
{
    [FirestoreData]
  public class Orders
    {
        private int _NB_No_Ship, _NB_Ship;
        private string _ID;
        [FirestoreDocumentId]
        public string ID { get => _ID; set { _ID = value; } }
        [FirestoreProperty]
        public int NB_NO_Ship { get => _NB_No_Ship; set { _NB_No_Ship = value; } }
        [FirestoreProperty]
        public int NB_Ship { get => _NB_Ship; set { _NB_Ship = value; } }

        public Customer customer = new Customer();
        public Employee employee = new Employee();
        public Time time = new Time();

        public async void GetMyData()
        {
            Query C = Database.StaticDataBase.DB.Db.Collection("Orders").Document(_ID).Collection("Customer");
            QuerySnapshot docsCustomer = await C.GetSnapshotAsync();
            Query E = Database.StaticDataBase.DB.Db.Collection("Orders").Document(_ID).Collection("Employee");
            QuerySnapshot docsEmployee = await E.GetSnapshotAsync();
            Query T = Database.StaticDataBase.DB.Db.Collection("Orders").Document(_ID).Collection("Time");
            QuerySnapshot docsTime = await T.GetSnapshotAsync();
            if (docsCustomer.Count > 0)
            {
                this.customer.Name = docsCustomer[0].GetValue<string>("Name");
                this.customer.ID = docsCustomer[0].Id;
                this.customer.City = docsCustomer[0].GetValue<string>("City");
                this.customer.Country = docsCustomer[0].GetValue<string>("Country");
               
            }
            else
            {
                MessageBox.Show("Count<0 Customer");
            }
            if (docsEmployee.Count > 0)
            {
                this.employee.ID = docsEmployee[0].Id;
                this.employee.Firstname = docsEmployee[0].GetValue<string>("Firtname");
                this.employee.Lastname = docsEmployee[0].GetValue<string>("Lastname");
                this.employee.City = docsEmployee[0].GetValue<string>("City");
                this.employee.Country = docsEmployee[0].GetValue<string>("Country");
                employee.test();

            }
            else
            {
                MessageBox.Show("Count<0 Emp");

            }
            if (docsTime.Count > 0)
            {
                this.time.Month = docsTime[0].GetValue<int>("Month");
                this.time.ID = docsTime[0].Id;
                this.time.Year = docsTime[0].GetValue<int>("Year");
                

            }
            else
            {

                MessageBox.Show("Count<0 time");
            }

            //
          
            GetData.CubeOrders.addOrders(this);
         
            //
        }



    }
}
