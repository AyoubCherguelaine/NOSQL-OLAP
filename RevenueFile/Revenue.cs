using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Google.Cloud.Firestore;
using System.Threading;

namespace OLAPFinal.RevenueFile
{
    [FirestoreData]
    public class Revenue
    {
        private string _ID;
        private double _OrderRevenue, _ShippedRevenue;

        [FirestoreDocumentId]
        public string ID { get => _ID; set { _ID = value; } }
        [FirestoreProperty]
        public double OrderRevenue { get => _OrderRevenue; set { _OrderRevenue = value; } }
        [FirestoreProperty]
        public double ShippedRevenue { get => _ShippedRevenue; set { _ShippedRevenue = value; } }
        public Time time = new Time();
        public Products products = new Products();
        public Customer customer = new Customer();

      
        public void test()
        {
            Console.WriteLine($"renenue ID{ID} \n OrderRevune :{ OrderRevenue} \nShippedRevenue{ShippedRevenue}");

        }

        private string IDCustomer, IDProduct, IDTime;

        public void dechefri()
        {
            string id = this.ID;

            List<string> list = new List<string>();
            list.Add("");
            list.Add("");
            list.Add("");
            list.Add("");
            int i = 0;
            foreach(char x in id)
            {
                if(x != '-')
                {
                    list[i] += x;

                }
                else
                {
                    i++;
                }
            }
            IDProduct = list[0];
            IDCustomer = list[1];
            IDTime = list[2] +"-" +list[3];

            Console.WriteLine("id programe :" +IDProduct+"\n id customer :" +IDCustomer +"id time :" +IDTime );

        }

        public  void GetRevenue(DocumentSnapshot doc)
        {
           
          
                if (doc.Exists)
                {
                    this.ID = doc.Id;

                this.dechefri();
                    this.OrderRevenue = doc.GetValue<double>("OrderRevenue");
                    this.ShippedRevenue = doc.GetValue<double>("ShippedRevenue");
               
                    products.GetProduct(ID,IDProduct);
                    customer.GetCutomer(ID,IDCustomer);
                    time.GetTime(ID,IDTime);
                 }



        }
   
    }
}
