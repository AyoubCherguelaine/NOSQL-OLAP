using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OLAPFinal.ProductsFile
{
   public class Products
    {
        private string _ID;
        private int _NunProducts;

        public string ID
        {
            get => _ID;
            set
            {
                _ID = value;
            }
        }
        public int NunProducts
        {
            get => _NunProducts;
            set
            {
                _NunProducts = value;
            }
        }

        public Suppliers Suppliers
        {
            get => default;
            set
            {
            }
        }

        public Category Category
        {
            get => default;
            set
            {
            }
        }

        public Price_Level Price_Level
        {
            get => default;
            set
            {
            }
        }

        public Stock_Level Stock_Level
        {
            get => default;
            set
            {
            }
        }
 

        public  void GetMyData()
        {
            if (_ID != null)
            {

            }
        }

    }
}
