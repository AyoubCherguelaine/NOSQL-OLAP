using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OLAPFinal.Database;
namespace OLAPFinal
{
   static public class Begin
    {
        public static void initBegin() {

            StaticDataBase.DB = new DataBase();
           Orders.GetData.init();
            //Orders.GetData.GetdataDB();
            RevenueFile.DownloadData.init();
            Thread thread = new Thread(delegate () { RevenueFile.DownloadData.DownloadDataRevenue(); });
            thread.Start();
            thread.Join();
            

        }
        public static NOSQLOLQP x;
        static public event EventHandler LoadingStart;
        static public event EventHandler LoadingFinish;
       
        static public void startUploading()
        {
            if(LoadingStart != null)
            {
                LoadingStart(null, EventArgs.Empty);
            }
        }

        static public void FinishUploading()
        {
            if (LoadingFinish != null)
            {
                LoadingFinish(null, EventArgs.Empty);
                
            }
        }
        

    }
}
