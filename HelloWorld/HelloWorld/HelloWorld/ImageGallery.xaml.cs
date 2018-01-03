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
            img.Source = "http://lorempixel.com/1920/1080/city/1";
            //img.CachingEnabled = "false";
        }
        public void PrevClick(Object sender,EventArgs e)
        {
            id--;
            if (id < 1)
                id = 10;
            img.Source = "http://lorempixel.com/1920/1080/city/"+id;
        }
        public void NextClick(Object sender, EventArgs e)
        {
            id++;
            if (id > 10)
                id = 1;
            img.Source = "http://lorempixel.com/1920/1080/city/" + id;
        }
    }
}