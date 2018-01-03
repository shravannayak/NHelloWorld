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
            //list1.ItemsSource = new List<String>
            //{
            //    "stack1",
            //    "Grid1"
            //};
        }
        //public void HandleSelect(Object sender,EventArgs e)
        //{
        //    var txt = (String)list1.SelectedItem;
        //    if (String.Compare(txt, "stack1") == 0)
        //        Detail= new NavigationPage(new stack1());
        //    else if (String.Compare(txt, "Grid1") == 0)
        //        Detail=new NavigationPage(new Grid1());


        //}
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
