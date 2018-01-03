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
	public partial class stack1 : ContentPage
	{
		public stack1 ()
		{
			InitializeComponent ();

		}
        async public void LoginClicked(Object sender,EventArgs e)
        {
            await DisplayActionSheet("Login", "Cancel", "Logout", "New user", "Registration", "Home");
        }
	}
}