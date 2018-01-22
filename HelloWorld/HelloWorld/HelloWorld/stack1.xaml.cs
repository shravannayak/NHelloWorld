using HelloWorld.CustomRenderer;
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
        async public void LoginClicked(object sender,EventArgs e)
        {
            await progBar.ProgressTo(1, 2000, Easing.Linear);
            await DisplayActionSheet("Login", "Cancel", "Logout", "New user", "Registration", "Home");
            await progBar.ProgressTo(0, 0, Easing.Linear);
        }
        public void RegClicked(object sender,EventArgs e)
        {
            DependencyService.Get<ITostCustom>().ShowToast("Register !!");
        }
	}
}