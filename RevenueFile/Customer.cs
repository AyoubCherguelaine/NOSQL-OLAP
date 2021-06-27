using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal.RevenueFile
{
   public class Customer
    {
        private string _Name, _City, _Country;
        private string _ID;
        [FirestoreDocumentId]
        public string ID { get => _ID; set { _ID = value; } }
        [FirestoreProperty]
        public string Name
        {
            get => _Name; set { _Name = value; }
        }
        [FirestoreProperty]
        public string City { get => _City; set { _City = value; } }
        [FirestoreProperty]
        public string Country { get => _Country; set { _Country = value; } }
    
        public void Test()
        {
            Console.WriteLine($"CustomerID{ID}\n  name {Name}\n  City{City}\n  Country{Country}");
        }
        public bool Equals(Customer o)
        {
            return this.Name == o.Name && Country == o.Country && this.City == o.City;
        }

        public async void GetCutomer(string IDRevenue)
        {
            Query q = Database.StaticDataBase.DB.Db.Collection("Revenue").Document(IDRevenue).Collection("Customer");
            
            var t = q.GetSnapshotAsync();
            t.Wait();
            QuerySnapshot document = t.Result;

           //Console.WriteLine("id customer L:" + document[0].Id);
                    this.ID = document[0].Id;
                    this.Name = document[0].GetValue<string>("Name");
                    this.City = document[0].GetValue<string>("City");
                    this.Country = document[0].GetValue<string>("Country");
              

          


        }
    }
}
