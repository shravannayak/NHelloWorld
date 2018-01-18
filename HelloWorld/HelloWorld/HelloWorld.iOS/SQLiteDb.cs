using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;


using Foundation;
using UIKit;
using HelloWorld.iOS;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(SQLiteDb))]
namespace HelloWorld.iOS
{
    public class SQLiteDb : ISQLite
    {
        public SQLiteDb() { }
        public SQLiteConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, "MySQLiteDB.db3");

            return new SQLiteConnection(path, true);
        }
    }
}