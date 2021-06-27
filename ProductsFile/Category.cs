using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal
{
    public class Category
    {
        private string _ID, _CategoryName;
        public string ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }

        public string CategoryName
        {
            get => _CategoryName;
            set
            {
                _CategoryName = value;
            }
        }

        public static async Task<Category> GetMyData(string IDProduct)
        {
            Category s;
            Query r = Database.StaticDataBase.DB.Db.Collection("Products").Document(IDProduct).Collection("Suppliers");
            QuerySnapshot doc = await r.GetSnapshotAsync();
            if (doc.Count > 0)
            {
               
                s = doc[0].ConvertTo<Category>();
                return s;
            }
            else
            {
                return null;
            }

        }

    }
}