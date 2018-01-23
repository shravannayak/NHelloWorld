using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.Content;
using Java.IO;
using System.Diagnostics;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelloWorld.Droid.Persistence;
using Xamarin.Forms;
using HelloWorld.Persistence;

[assembly: Dependency(typeof(SaveAndroid))]
namespace HelloWorld.Droid.Persistence
{
    class SaveAndroid : ISave
    {
        public void Save(string filename, string contentType, MemoryStream stream)
        {
            string fileName = filename;
            string exception = string.Empty;
            string root = null;
            if (fileName.Contains(",") && !(global::Android.OS.Build.VERSION.SdkInt < global::Android.OS.BuildVersionCodes.Lollipop))
                return;
            else if (fileName.Contains(",") && global::Android.OS.Build.VERSION.SdkInt < global::Android.OS.BuildVersionCodes.Lollipop)
                fileName = fileName.Split(',')[0];

            if (global::Android.OS.Environment.IsExternalStorageEmulated)
            {
                //root = Path.Combine(global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, global::Android.OS.Environment.DirectoryDownloads);
                root = global::Android.OS.Environment.ExternalStorageDirectory.ToString();
            }
            else
                root = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            Java.IO.File myDir = new Java.IO.File(root + "/Example Pdf");
            myDir.Mkdir();

            Java.IO.File file = new Java.IO.File(myDir, fileName);

            if (file.Exists()) file.Delete();

            try
            {
                FileOutputStream outs = new FileOutputStream(file);
                outs.Write(stream.ToArray());

                outs.Flush();
                outs.Close();
            }
            catch (Exception e)
            {
                exception = e.ToString();
            }
            //if (global::Android.OS.Build.VERSION.SdkInt < global::Android.OS.BuildVersionCodes.Lollipop)
            //{
                try
                {
                    if (file.Exists() && contentType != "application/html")
                    {
                        global::Android.Net.Uri path = global::Android.Net.Uri.FromFile(file);
                        string extension = global::Android.Webkit.MimeTypeMap.GetFileExtensionFromUrl(global::Android.Net.Uri.FromFile(file).ToString());
                        string mimeType = global::Android.Webkit.MimeTypeMap.Singleton.GetMimeTypeFromExtension(extension);
                        Intent intent = new Intent(Intent.ActionView);
                        intent.SetDataAndType(path, mimeType);
                        Forms.Context.StartActivity(Intent.CreateChooser(intent, "Choose App"));
                    }
                }
                catch (Exception e)
                {
                    e.Data.Clear();
                }
            //}
        }
    }
}