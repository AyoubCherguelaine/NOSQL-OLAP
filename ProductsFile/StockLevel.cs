using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal
{
    public class Stock_Level
    {
        private string _ID, _StockLevel;

        public string ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }
        public string StockLevel
        {
            get => _StockLevel;
            set
            {
                _StockLevel = value;
            }
        }

        public static async Task<Stock_Level> GetMyData(string IDProduct)
        {
            Stock_Level s;
            Query r = Database.StaticDataBase.DB.Db.Collection("Products").Document(IDProduct).Collection("Suppliers");
            QuerySnapshot doc = await r.GetSnapshotAsync();
            if (doc.Count > 0)
            {
                s = doc[0].ConvertTo<Stock_Level>();
                return s;
            }
            else
            {
                return null;
            }

        }

    }
}