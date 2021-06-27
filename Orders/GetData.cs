using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using OLAPFinal.Database;

namespace OLAPFinal.Orders
{
    public static class GetData
    {
        static public string mode="Normal";
        static public List<string> query = new List<string>();
        static public event EventHandler changeDrill;
        static public DataOrders CubeOrders;
        static public void init()
        {
            List<string> Axes = new List<string>();
            Axes.Add("Employee");
            Axes.Add("Customer");
            Axes.Add("Time");
            CubeOrders = new DataOrders(Axes);
        }
        static public List<string> IDOrders = new List<string>();
        static public Task t = new Task(new Action(UploadData));
        static public void changeDrillFunction(string arg)
        {
            if(changeDrill != null)
            {
                changeDrill(arg, EventArgs.Empty);
            }
        }
        static public void GetdataDB()
        {
            
            
         

            if (CubeOrders.num ==1)
            {
              //  StaticDataBase.DB = new DataBase();
              
                t.Start();
                t.Wait();
            }

          

        }
        public static  Task<QuerySnapshot> GetDocumentSnapshots(string path)
        {
            try
            {
                Query query = StaticDataBase.DB.Db.Collection(path);
                // query.WhereEqualTo()

                return query.GetSnapshotAsync();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
           
        }
        private static FormWelcome form ;
        
        public static int idsNumber;
        static private async  void UploadData()
        {
            QuerySnapshot OrdersDocs =await GetDocumentSnapshots("Orders");
            idsNumber = OrdersDocs.Count;

            int i = 0;
            foreach(DocumentSnapshot Orders in OrdersDocs)
            {
                IDOrders.Add(Orders.Id);
                Orders ord = new Orders();
               
                ord = Orders.ConvertTo<Orders>();
                ord.GetMyData();
                i++;
                if (i == 40)
                {
                    break;
                }
              }

        }
  
    }
}
