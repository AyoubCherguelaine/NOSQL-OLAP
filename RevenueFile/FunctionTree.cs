using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAPFinal.RevenueFile
{
    public static class FunctionTree
    {
        private static void Customer1(Revenue R)
        {
            if(DownloadData.Roll["Customer"] == "Name")
            {
                if( DownloadData.Cube.ContainsKey(R.customer.Name))
                {
                    // too next
                    if(DownloadData.axes[1] == "Time")
                    {
                        // next axe is time
                        Time2(R.customer.Name, R);
                    }
                    else
                    {
                        //next axe is product
                        Product2(R.customer.Name, R);
                    }
                }
                else
                {
                    Dictionary<string, Dictionary<string, ArrayList>> r = new Dictionary<string, Dictionary<string, ArrayList>>();
                    DownloadData.Cube.Add(R.customer.Name, r);
                    Customer1(R);
                }
            }
            else
            {
                if(DownloadData.Roll["Customer"] == "City")
                {
                    if (DownloadData.Cube.ContainsKey(R.customer.City))
                    {
                        // too next
                        if (DownloadData.axes[1] == "Time")
                        {
                            // next axe is time
                            Time2(R.customer.City, R);
                        }
                        else
                        {
                            //next axe is product
                            Product2(R.customer.City, R);
                        }
                    }
                    else
                    {

                        Dictionary<string, Dictionary<string, ArrayList>> r = new Dictionary<string, Dictionary<string, ArrayList>>();
                        DownloadData.Cube.Add(R.customer.City, r);
                        Customer1(R);
                    }
                }
                else
                {
                    if (DownloadData.Cube.ContainsKey(R.customer.Country))
                    {
                        // too next
                        if (DownloadData.axes[1] == "Time")
                        {
                            // next axe is time
                            Time2(R.customer.Country, R);
                        }
                        else
                        {
                            //next axe is product
                            Product2(R.customer.Country, R);
                        }
                    }
                    else
                    {

                        Dictionary<string, Dictionary<string, ArrayList>> r = new Dictionary<string, Dictionary<string, ArrayList>>();
                        DownloadData.Cube.Add(R.customer.Country, r);
                        Customer1(R);
                    }
                }
            }

        }


        private static void Time1(Revenue R)
        {
            if( DownloadData.Roll["Time"] =="Month")
            {
                if (DownloadData.Cube.ContainsKey(R.time.ID))
                {
                    //to next
                    if (DownloadData.axes[1] == "Customer")
                    {
                        // next axe is Customer
                        Customer2(R.time.ID, R);
                    }
                    else
                    {
                        //next axe is product
                        Product2(R.time.ID, R);
                    }

                }
                else
                {

                    Dictionary<string, Dictionary<string, ArrayList>> r = new Dictionary<string, Dictionary<string, ArrayList>>();
                    DownloadData.Cube.Add(R.time.ID, r);
                    Time1(R);
                }
            }
            else
            {
                if (DownloadData.Cube.ContainsKey(Convert.ToString( R.time.Year)))
                {
                    //to next
                    if (DownloadData.axes[1] == "Customer")
                    {
                        // next axe is Customer
                        Customer2(Convert.ToString(R.time.Year), R);

                    }
                    else
                    {
                        //next axe is product
                        Product2(Convert.ToString(R.time.Year), R);
                    }

                }
                else
                {

                    Dictionary<string, Dictionary<string, ArrayList>> r = new Dictionary<string, Dictionary<string, ArrayList>>();
                    DownloadData.Cube.Add(Convert.ToString(R.time.Year), r);
                    Time1(R);
                }
            }
        }


        private static void Product1(Revenue R)
        {
            if (DownloadData.Roll["Product"] == "ProductName")
            {
                if (DownloadData.Cube.ContainsKey(R.products.ProductName))
                {
                    // too next
                    if (DownloadData.axes[1] == "Time")
                    {
                        // next axe is time
                        Time2(R.products.ProductName, R);
                    }
                    else
                    {
                        //next axe is Cutomer
                        Customer2(R.products.ProductName, R);
                    }
                }
                else
                {

                    Dictionary<string, Dictionary<string, ArrayList>> r = new Dictionary<string, Dictionary<string, ArrayList>>();
                    DownloadData.Cube.Add(R.products.ProductName, r);
                    Product1(R);
                }
            }
            else
            {
                if (DownloadData.Roll["Product"] == "Category")
                {
                    if (DownloadData.Cube.ContainsKey(R.products.CategoryName))
                    {
                        // too next
                        if (DownloadData.axes[1] == "Time")
                        {
                            // next axe is time
                            Time2(R.products.CategoryName, R);
                        }
                        else
                        {
                            //next axe is Cutomer
                            Customer2(R.products.CategoryName, R);
                        }
                    }
                    else
                    {

                        Dictionary<string, Dictionary<string, ArrayList>> r = new Dictionary<string, Dictionary<string, ArrayList>>();
                        DownloadData.Cube.Add(R.products.CategoryName, r);
                        Product1(R);
                    }
                }
               
            }

        }


        private static void Customer2(string keyFirst,Revenue R)
        {
            if (DownloadData.Roll["Customer"] == "Name")
            {
                if (DownloadData.Cube[keyFirst].ContainsKey(R.customer.Name))
                {
                    string x = R.customer.Name;
                    // too next
                    if (DownloadData.axes[2] == "Time")
                    {
                        // next axe is time
                        Time3(keyFirst, x, R);
                    }
                    else
                    {
                        //next axe is product
                        Product3(keyFirst, x, R);
                    }
                }
                else
                {
                     Dictionary<string, ArrayList> r = new Dictionary<string, ArrayList>();
                    DownloadData.Cube[keyFirst].Add(R.customer.Name, r);
                    Customer2(keyFirst,R);
                }
            }
            else
            {
                if (DownloadData.Roll["Customer"] == "City")
                {
                    if (DownloadData.Cube[keyFirst].ContainsKey(R.customer.City))
                    {
                        string x = R.customer.City;
                        // too next
                        if (DownloadData.axes[2] == "Time")
                        {
                            // next axe is time
                            Time3(keyFirst, x, R);
                        }
                        else
                        {
                            //next axe is product
                            Product3(keyFirst, x, R);
                        }
                    }
                    else
                    {
                        Dictionary<string, ArrayList> r = new Dictionary<string, ArrayList>();
                        DownloadData.Cube[keyFirst].Add(R.customer.City, r);
                        Customer2(keyFirst, R);
                    }
                }
                else
                {
                    if (DownloadData.Cube[keyFirst].ContainsKey(R.customer.Country))
                    {
                        string x = R.customer.Country;
                        // too next
                        if (DownloadData.axes[2] == "Time")
                        {
                            // next axe is time
                            Time3(keyFirst, x, R);
                        }
                        else
                        {
                            //next axe is product

                            Product3(keyFirst, x, R);
                        }
                    }
                    else
                    {
                        Dictionary<string, ArrayList> r = new Dictionary<string, ArrayList>();
                        DownloadData.Cube[keyFirst].Add(R.customer.Country, r);
                        Customer2(keyFirst, R);
                    }
                }
            }

        }

        
        private static void Time2(string keyFirst,Revenue R)
        {
            Console.WriteLine("key first : " + keyFirst);
            Console.WriteLine("\n\ntest : " + DownloadData.Cube[keyFirst] == null);
            if (DownloadData.Roll["Time"] == "Month")
            {
                if (DownloadData.Cube[keyFirst].ContainsKey(R.time.ID))
                {

                    string x = R.time.ID;
                    //to next
                    if (DownloadData.axes[2] == "Customer")
                    {
                        // next axe is Customer
                        Customer3(keyFirst, x, R);
                    }
                    else
                    {
                        //next axe is product
                        Product3(keyFirst, x, R);
                    }

                }
                else
                {

                    Dictionary<string, ArrayList> r = new Dictionary<string, ArrayList>();
                    DownloadData.Cube[keyFirst].Add(R.time.ID, r);
                    Time2(keyFirst, R);
                }
            }
            else
            {
                if (DownloadData.Cube[keyFirst].ContainsKey(Convert.ToString(R.time.Year)))
                {
                    //to next

                    string x = Convert.ToString(R.time.Year);
                    if (DownloadData.axes[2] == "Customer")
                    {
                        // next axe is Customer
                        Customer3(keyFirst, x, R);
                    }
                    else
                    {
                        //next axe is product
                        Product3(keyFirst, x, R);
                    }

                }
                else
                {

                    Dictionary<string, ArrayList> r = new Dictionary<string, ArrayList>();
                    DownloadData.Cube[keyFirst].Add(Convert.ToString(R.time.Year), r);
                    Time2(keyFirst, R);
                }
            }
        }

        private static void Product2(string keyFirst,Revenue R)
        {
            if (DownloadData.Roll["Product"] == "ProductName")
            {

                if (DownloadData.Cube[keyFirst].ContainsKey(R.products.ProductName))
                {
                    string x = R.products.ProductName;
                    // too next
                    if (DownloadData.axes[2] == "Time")
                    {
                        // next axe is time
                        Time3(keyFirst, x, R);
                    }
                    else
                    {
                        //next axe is Cutomer
                        Customer3(keyFirst, x, R);
                    }
                }
                else
                {

                    Dictionary<string, ArrayList> r = new Dictionary<string, ArrayList>();
                    DownloadData.Cube[keyFirst].Add(R.products.ProductName, r);
                    Product2(keyFirst, R);
                }
            }
            else
            {
                if (DownloadData.Roll["Product"] == "Category")
                {
                    if (DownloadData.Cube[keyFirst].ContainsKey(R.products.CategoryName))
                    {
                        string x = R.products.ProductName;
                        // too next
                        if (DownloadData.axes[2] == "Time")
                        {
                            // next axe is time
                            Time3(keyFirst, x, R);
                        }
                        else
                        {
                            //next axe is Cutomer

                            Customer3(keyFirst, x, R);
                        }
                    }
                    else
                    {

                        Dictionary<string, ArrayList> r = new Dictionary<string, ArrayList>();
                        DownloadData.Cube[keyFirst].Add(R.products.CategoryName, r);
                        Product2(keyFirst, R);
                    }
                }

            }

        }

        private static void Customer3(string keyFirst,string keyscnd, Revenue R)
        {
            if (DownloadData.Roll["Customer"] == "Name")
            {
                if (DownloadData.Cube[keyFirst][keyscnd].ContainsKey(R.customer.Name))  {
                    // too next
                   //cas not availaibe
                }
                else
                {
                    ArrayList list = new ArrayList();
                    list.Add(R);
                    DownloadData.Cube[keyFirst][keyscnd].Add(R.customer.Name, list);
                    
                   
                }
            }
            else
            {
                if (DownloadData.Roll["Customer"] == "City")
                {
                    if (DownloadData.Cube[keyFirst][keyscnd].ContainsKey(R.customer.City))
                    {
                        // too next
                        DownloadData.Cube[keyFirst][keyscnd][R.customer.City].Add(R);
                    }
                    else
                    {
                        ArrayList list = new ArrayList();
                        list.Add(R);
                        DownloadData.Cube[keyFirst][keyscnd].Add(R.customer.City, list);

                    }
                }
                else
                {
                    if (DownloadData.Cube[keyFirst].ContainsKey(R.customer.Country))
                    {
                        // too next
                        DownloadData.Cube[keyFirst][keyscnd][R.customer.Country].Add(R);
                    }
                    else
                    {
                        ArrayList list = new ArrayList();
                        list.Add(R);
                        try
                        {
                            DownloadData.Cube[keyFirst][keyscnd].Add(R.customer.Country, list);
                        }
                        catch (Exception eee)
                        {

                        }
                    }
                }
            }

        }

        private static void Time3(string keyFirst, string keyscnd, Revenue R)
        {
            if (DownloadData.Roll["Time"] == "Month")
            {
                if (DownloadData.Cube[keyFirst][keyscnd].ContainsKey(R.time.ID))
                {
                    //to next
                  //noway

                }
                else
                {
                    ArrayList list = new ArrayList();
                    list.Add(R);
                    DownloadData.Cube[keyFirst][keyscnd].Add(R.time.ID, list);
                 
                }
            }
            else
            {
                if (DownloadData.Cube[keyFirst][keyscnd].ContainsKey(Convert.ToString(R.time.Year)))
                {
                    //to next
                    DownloadData.Cube[keyFirst][keyscnd][Convert.ToString(R.time.Year)].Add(R);

                }
                else
                {
                    ArrayList list = new ArrayList();
                    list.Add(R);
                    DownloadData.Cube[keyFirst][keyscnd].Add(Convert.ToString(R.time.Year), list);
                  
                }
            }
        }

        private static void Product3(string keyFirst, string keyscnd, Revenue R)
        {
            if (DownloadData.Roll["Product"] == "ProductName")
            {
                if (DownloadData.Cube[keyFirst][keyscnd].ContainsKey(R.products.ProductName))
                {
                    // too next
                    DownloadData.Cube[keyFirst][keyscnd][R.products.ProductName].Add(R);

                }
                else
                {
                    ArrayList list = new ArrayList();
                    list.Add(R);
                    DownloadData.Cube[keyFirst][keyscnd].Add(R.products.ProductName, list);
                  
                }
            }
            else
            {
                if (DownloadData.Roll["Product"] == "Category")
                {
                    if (DownloadData.Cube[keyFirst][keyscnd].ContainsKey(R.products.CategoryName))
                    {
                        // too next
                        DownloadData.Cube[keyFirst][keyscnd][R.products.CategoryName].Add(R);
                    }
                    else
                    {
                        ArrayList list = new ArrayList();
                        list.Add(R);
                        DownloadData.Cube[keyFirst][keyscnd].Add(R.products.CategoryName, list);
                      
                    }
                }

            }

        }

        public static void AddRevenue(Revenue R)
        {

            DownloadData.RevenueArray.Add(R);

            if(DownloadData.axes[0] == "Customer")
            {
                Customer1(R);
            }
            else
            {
                if(DownloadData.axes[0] == "Time")
                {
                    Time1(R);
                }
                else
                {
                    Product1(R);
                }
            }
        }
      
    
        public static void Roll()
        {
            Console.WriteLine("i m in Roll");
            DownloadData.Cube = new Dictionary<string, Dictionary<string, Dictionary<string, ArrayList>>>();

            foreach(Revenue R in DownloadData.RevenueArray)
            {
                if (DownloadData.axes[0] == "Customer")
                {
                    Customer1(R);
                }
                else
                {
                    if (DownloadData.axes[0] == "Time")
                    {
                        Time1(R);
                    }
                    else
                    {
                        Product1(R);
                    }
                }
            }

            Console.WriteLine("Finish Roll fuction");

            DownloadData.act();
        
        
        }
    }
}
