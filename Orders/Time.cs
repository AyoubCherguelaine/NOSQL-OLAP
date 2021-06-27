using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal.Orders
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

        public DateTime Date= new DateTime();
        
        public void test()
        {
            Console.WriteLine($"Month{Month},, year{Year}");
        }

        public bool Equals(Time T)
        {
            return Month == T.Month && Year == T.Year;
        }

    }
}
