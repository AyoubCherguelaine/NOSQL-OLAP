using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal.RevenueFile
{
   public class Time
    {
        private string _ID,_ID_DB;
        private bool done = false;
        public string ID { get => _ID; set { _ID = value; } }
        [FirestoreDocumentId]
        public string ID_DB { get => _ID_DB; set { _ID_DB = value; } }

        private int _month, _year;
        [FirestoreProperty]
        public int Month
        {
            get => _month;
            set { _month = value; if (!done) done = true; else createID(); }
        }
        [FirestoreProperty]
        public int Year
        {
            get => _year;
            set { _year = value; if (!done) done = true; else createID(); }
        }
        private void  createID()
        {
            ID = Year + "/" + Month;
        }

        
        public void test()
        {
            Console.WriteLine($"Month : {Month}\n year : {Year}");
        }

        public bool Equals(Time T)
        {
            return Month == T.Month && Year == T.Year;
        }

        public async void GetTime(string IDRevenue)
        {
            Query q = Database.StaticDataBase.DB.Db.Collection("Revenue").Document(IDRevenue).Collection("Time");
          

            var t = q.GetSnapshotAsync();
            t.Wait();
            QuerySnapshot document = t.Result;
            if (document.Count > 0)
            {
                if (document[0].Exists)
                {
                    this.ID = document[0].Id;
                    this.Month = document[0].GetValue<int>("Month");
                    this.Year = document[0].GetValue<int>("Year");
                }

            }
            else
            {
                Console.WriteLine("Error in get Time in the Revenue Doc :" + IDRevenue);
            }


        }
    }
}
