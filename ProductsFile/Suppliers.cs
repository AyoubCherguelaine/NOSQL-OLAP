using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
namespace OLAPFinal
{
    public class Suppliers
    {
        public string _SupplierName, _City, _Country, _ID;
        public string SupplierName
        {
            get => _SupplierName;
            set { _SupplierName = value; }
        }
        public string City
        {
            get => _City;
            set
            {
                _City = value;
            }
        }
        public string Coutry
        {
            get => _Country;
            set
            {
                _Country = value;
            }
        }

        public string ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }
  
        public static async Task<Suppliers> GetMyData(string IDProduct)
        {
            Suppliers s = new Suppliers();
          Query r =   Database.StaticDataBase.DB.Db.Collection("Products").Document(IDProduct).Collection("Suppliers");
            QuerySnapshot doc = await r.GetSnapshotAsync();
            if (doc.Count > 0)
            {
                s = doc[0].ConvertTo<Suppliers>();
                return s;
            }
            else
            {
                return null;
            }

        }
   
    }
}