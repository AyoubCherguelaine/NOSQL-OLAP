using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using System.Threading;

namespace OLAPFinal.RevenueFile
{
    [FirestoreData]
    public class Products
    {
        private string _ID, _ProductName, _CategoryName;
        private int _CategoryID;



        [FirestoreDocumentId]
        public string ID{ get => _ID; set { _ID = value; } }
        [FirestoreProperty]
        public string ProductName { get => _ProductName; set { _ProductName = value; } }
        [FirestoreProperty]
        public int CategoryID { get => _CategoryID; set { _CategoryID = value; } }
        [FirestoreProperty]
        public string CategoryName { get => _CategoryName; set { _CategoryName = value; } }


        public Products()
        {

        }


        public void test()
        {
            Console.WriteLine("Product  num :" + ID);
            Console.WriteLine("Products name :" + ProductName);
            Console.WriteLine("Categoryname :" + CategoryName);
            Console.WriteLine("categoryID :" + CategoryID);
        }

        public async void GetProduct(string IDRevenue,string id)
        {
            DocumentReference reference = Database.StaticDataBase.DB.Db.Collection("Revenue").Document(IDRevenue).Collection("Product").Document(id);
           // Query q = Database.StaticDataBase.DB.Db.Collection("Revenue").Document(IDRevenue).Collection("Product");

            var t = reference.GetSnapshotAsync();
           
          //  var t = q.GetSnapshotAsync();
            t.Wait();
            // QuerySnapshot document = t.Result;
            DocumentSnapshot document = t.Result;
           
                if (document.Exists)
                {
                    this.ID = document.Id;
                    this.ProductName = document.GetValue<string>("ProductName");
                    this.CategoryName = document.GetValue<string>("CategoryName");
                    this.CategoryID = document.GetValue<int>("CategoryID");
                }

           


        }

    }
}
