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
using SQLite;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using HelloWorld;
using HelloWorld.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteDb))]
namespace HelloWorld.Droid
{
    public class SQLiteDb : ISQLite
    {
        public SQLiteDb() { }
        public SQLiteConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLiteDB.db3");

            return new SQLiteConnection(path, true);
        }
    }
}