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
	public partial class stack2 : ContentPage
	{
		public stack2 ()
		{
			InitializeComponent ();
		}
        public void BtnClick(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Trim().Equals("X"))
                NewLayout.IsVisible = false;
            else
                NewLayout.IsVisible = true; 
        }
	}
}