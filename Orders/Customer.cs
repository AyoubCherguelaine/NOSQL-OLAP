using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal.Orders
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
            Console.WriteLine($"name {Name}\nCity{City}\nCountry{Country}");
        }
        public bool Equals(Customer o)
        {
            return this.Name == o.Name && Country == o.Country && this.City == o.City;
        }
    }
}
