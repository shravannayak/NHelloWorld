using HelloWorld.iOS.Persistence;
using HelloWorld.Persistence;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;
using MessageUI;

using Foundation;
using UIKit;
using QuickLook;

[assembly: Dependency(typeof(SaveIOS))]
namespace HelloWorld.iOS.Persistence
{
    class SaveIOS : ISave
    {
        public void Save(string filename, string contentType, MemoryStream stream)
        {
            string exception = string.Empty;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, filename);
            try
            {
                FileStream fileStream = File.Open(filePath, FileMode.Create);
                stream.Position = 0;
                stream.CopyTo(fileStream);
                fileStream.Flush();
                fileStream.Close();
            }
            catch (Exception e)
            {
                exception = e.ToString();
            }
            if (contentType == "application/html" || exception != string.Empty)
                return;
            UIViewController currentController = UIApplication.SharedApplication.KeyWindow.RootViewController;
            while (currentController.PresentedViewController != null)
                currentController = currentController.PresentedViewController;
            UIView currentView = currentController.View;

            QLPreviewController qlPreview = new QLPreviewController();
            QLPreviewItem item = new QLPreviewItemBundle(filename, filePath);
            qlPreview.DataSource = new PreviewControllerDS(item);

            //UIViewController uiView = currentView as UIViewController;

            currentController.PresentViewController((UIViewController)qlPreview, true, (Action)null);
        }
    }
}
