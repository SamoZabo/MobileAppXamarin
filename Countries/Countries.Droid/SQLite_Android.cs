using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Countries.Interface;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Countries.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Countries.Droid
{    
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {

        }
        public SQLiteConnection GetConnection()
        {
            // Set the name of the database
            var sqliteFilename = "Countries.db";
            // Create the path 
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}