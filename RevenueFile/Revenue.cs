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

        public  void GetRevenue(DocumentSnapshot doc)
        {
           
          
                if (doc.Exists)
                {
                    this.ID = doc.Id;
                    this.OrderRevenue = doc.GetValue<double>("OrderRevenue");
                    this.ShippedRevenue = doc.GetValue<double>("ShippedRevenue");
               
                    products.GetProduct(ID);
                    customer.GetCutomer(ID);
                    time.GetTime(ID);
                
               

                }



        }
   
    }
}
