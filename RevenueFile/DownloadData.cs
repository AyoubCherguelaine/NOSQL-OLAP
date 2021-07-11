using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace OLAPFinal.RevenueFile
{
  public static partial class  DownloadData
    {
        public static List<string> axes;
        public static ArrayList RevenueArray =new ArrayList();
        public static Dictionary<string, string> Roll;
        public static string  Drill;// contient 2 valeur || ShippedRevenue . OrderRevenue
        public static Dictionary<string, Dictionary<string, Dictionary<string, ArrayList>>> Cube;

        public static event EventHandler Reflesh;

        public static event EventHandler finDownload;
        public static void init()
        {
            axes = new List<string>();
            Roll = new Dictionary<string,string>();
            axes.Add("Customer");
            axes.Add("Time");
            axes.Add("Product");
            Roll.Add("Customer", "Name");
            Roll.Add("Time", "Month");
            Roll.Add("Product", "ProductName");
            Drill = "OrderRevenue";
            Cube = new Dictionary<string, Dictionary<string, Dictionary<string, ArrayList>>>();


        }

        private   static Task<QuerySnapshot> GetQSnapRevenue()
        {
            
                Console.WriteLine("try to download from Revenue");
                Query q = Database.StaticDataBase.DB.Db.Collection("Revenue");

                return q.GetSnapshotAsync();
            
        }

       public static void  act()
        {
            // Try r = new Try();
            // r.Show();
            Console.WriteLine("\n\nAct \n\n");
            if(Reflesh != null)
            {
                Console.WriteLine("\n\n\nReflesh rah yebdda");
                Reflesh(null, EventArgs.Empty);
            }
           

        }

        public async static void DownloadDataRevenue()
        {

            //  Thread GetRevenue = new Thread(delegate () {   GetQSnapRevenue(); });
            QuerySnapshot documents =await GetQSnapRevenue();
            Console.WriteLine("\nGetRevenue start");
          //  GetRevenue.Start();
            Console.WriteLine("\nGetRevenue join");
         //   GetRevenue.Join();
            Console.WriteLine("Doc nu ll : " + documents == null);

            int i = 0;
                foreach (DocumentSnapshot doc in documents)
                {
                    Revenue revenue = new Revenue();
                Console.WriteLine("place data of : " + doc.Id);
               revenue.GetRevenue(doc);
          
              
                FunctionTree.AddRevenue(revenue);
                Console.WriteLine($"Revenue Test : \nrevenueID: {revenue.ID}\n   OrderRevenue:{revenue.OrderRevenue}\n   CutomerName :{revenue.customer.Name} \n   ProductName : {revenue.products.ProductName }");

                i++;
                Console.WriteLine("\n\n\n\n\n\n " + i + "\n\n\n\n\n\n\n\n\n\n\n");
                 if (i == 141)
                 { 
                    break;
                }
            }
              
               
            
            if(finDownload != null)
            {
                finDownload(null, EventArgs.Empty);
            }
        }

    }
}
