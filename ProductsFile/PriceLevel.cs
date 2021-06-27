using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal
{
    public class Price_Level
    {
        private string _ID, _PriceLevel;

        public string ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }
        public string PriceLevel
        {
            get => _PriceLevel;
            set
            {
                _PriceLevel = value;
            }
        }
        public static async Task<Price_Level> GetMyData(string IDProduct)
        {
            Price_Level s;
            Query r = Database.StaticDataBase.DB.Db.Collection("Products").Document(IDProduct).Collection("Suppliers");
            QuerySnapshot doc = await r.GetSnapshotAsync();
            if (doc.Count > 0)
            {
                s = doc[0].ConvertTo<Price_Level>();
                return s;
            }
            else
            {
                return null;
            }

        }
    }
}