using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using System.Windows.Forms;
using System.Collections;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace OLAPFinal.Database
{
    public class DataBase
    {
       public FirestoreDb Db;
        public DataBase()
        {
           
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ConsoleFileJson.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            Db = FirestoreDb.Create("olapnosql");
            Console.WriteLine("\n\n\n\n\n connect with firestore\n\n\n\n");
        }

    }
}
