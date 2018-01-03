using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageGallery : ContentPage
	{
        int id = 1;
        public ImageGallery ()
		{
			InitializeComponent ();

            LoadImage();
        }
        void LoadImage()
        {
            img.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", id)),
                CachingEnabled = false
            };
        }
        public void PrevClick(Object sender,EventArgs e)
        {
            id--;
            if (id == 1)
                id = 10;
            LoadImage();
        }
        public void NextClick(Object sender, EventArgs e)
        {
            id++;
            if (id == 11)
                id = 1;
            LoadImage();
        }
    }
}