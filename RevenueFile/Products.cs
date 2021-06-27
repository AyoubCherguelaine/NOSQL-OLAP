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

        public async void GetProduct(string IDRevenue)
        {
            Query q = Database.StaticDataBase.DB.Db.Collection("Revenue").Document(IDRevenue).Collection("Product");
           
            var t = q.GetSnapshotAsync();
            t.Wait();
            QuerySnapshot document = t.Result;
            if (document.Count > 0)
            {
                if (document[0].Exists)
                {
                    this.ID = document[0].Id;
                    this.ProductName = document[0].GetValue<string>("ProductName");
                    this.CategoryName = document[0].GetValue<string>("CategoryName");
                    this.CategoryID = document[0].GetValue<int>("CategoryID");
                }

            }
            else
            {
                Console.WriteLine("Error in get Time in the Revenue Doc :" + IDRevenue);
            }


        }

    }
}
