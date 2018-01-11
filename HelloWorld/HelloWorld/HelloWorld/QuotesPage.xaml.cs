using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfAutoComplete.XForms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
        public string[] str = new string[] { "One", "Two", "Three", "Four", "Five", "Six" };
        public ObservableCollection<string> countryNames = new ObservableCollection<string>
            {
                "Uganda",
                "Ukraine",
                "Canada",
                "United Arab Emirates",
                "France",
                "United Kingdom",
                "China",
                "United States",
                "Japan",
            };
        int i = 0;
        public QuotesPage()
        {
            
            InitializeComponent ();
            quote.Text = str[i];
            
            auto.DataSource = countryNames;
        }
        
        async public void Handle_clicked(Object sender,EventArgs e)
        {
            await btn.ScaleTo(0.5, 3000, Easing.BounceIn);
            await btn.ScaleTo(1, 3000, Easing.BounceOut);
            i++;
            if (i >= str.Length)
                i = 0;

            quote.Text = str[i];

        }
    }
}