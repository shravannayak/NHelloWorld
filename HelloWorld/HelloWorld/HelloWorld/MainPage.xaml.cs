using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();
        }
        public async void OpenQuotes (Object sender,EventArgs e)
        {
            await Navigation.PushAsync(new QuotesPage());
            //IsPresented = false;
        }
        public async void OpenLStack(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new stack1());
        }
        public async void OpenIStack(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new stack2());
        }
        public async void OpenGrid(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid1());
        }
        public async void OpenAbsolute1(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new absolute1());
        }
        public async void OpenAbsolute2(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new absolute2());
        }
        public async void OpenGallery(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageGallery());
        }
    }
}
