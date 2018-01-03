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
	public partial class QuotesPage : ContentPage
	{
        public string[] str = new string[] { "One", "Two", "Three", "Four", "Five", "Six" };
        int i = 0;
        public QuotesPage ()
		{
			InitializeComponent ();
            quote.Text = str[i];
		}
        
        public void Handle_clicked(Object sender,EventArgs e)
        {
            i++;
            if (i >= str.Length)
                i = 0;

            quote.Text = str[i];

        }
    }
}