using HelloWorld.CustomRenderer;
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

            //NavigationPage.HasNavigationBarProperty(this, false);
            //NavigationPage.SetHideNavigationBar(MainPage, true);
            //list1.ItemsSource = new List<String>
            //{
            //    "stack1",
            //    "Grid1"
            //};
            //img.Source = ImageSource.FromResource("HelloWorld.Images.bulbimage.jpg");
        }

        public object NavigationController { get; }
        //public void HandleSelect(Object sender,EventArgs e)
        //{
        //    var txt = (String)list1.SelectedItem;
        //    if (String.Compare(txt, "stack1") == 0)
        //        Detail= new NavigationPage(new stack1());
        //    else if (String.Compare(txt, "Grid1") == 0)
        //        Detail=new NavigationPage(new Grid1());


        //}
        public async void Btnclick(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            var id = btn.ClassId;
            switch(id)
            {
                case "1": await Navigation.PushAsync(new absolute1()); break;
                case "2": await Navigation.PushAsync(new Sql_CRUD()); break;
                case "3": await Navigation.PushAsync(new absolute2()); break;
                case "4": await Navigation.PushAsync(new Grid1()); break;
                case "5": await Navigation.PushAsync(new ImageGallery()); break;
                case "6": await Navigation.PushAsync(new QuotesPage()); break;
                case "7": await Navigation.PushAsync(new stack1()); break;
                case "8": await Navigation.PushAsync(new stack2()); break;
                case "9": await Navigation.PushAsync(new FormsPage()); break;
                case "10": await Navigation.PushAsync(new SliderText()); break;
                case "11": await Navigation.PushAsync(new BoxViewClock()); break;
                case "12": await Navigation.PushAsync(new DotMatrixClock()); break;
               
            }
        }
        public void OnSelect(object sender,SelectedItemChangedEventArgs e)
        {
            string str = (string)sender;
            DependencyService.Get<ITostCustom>().ShowToast(str);
        }

       
    }
}
