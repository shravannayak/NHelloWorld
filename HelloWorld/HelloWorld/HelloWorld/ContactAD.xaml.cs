using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactAD : ContentPage
	{
		public ContactAD ()
		{
			InitializeComponent ();
		}
        public ContactAD(Contact contact)
        {
            InitializeComponent();
            first.Label = contact.FirstName.ToString();
            last.Label = contact.LastName.ToString();
            phone.Label = contact.LastName.ToString();
            email.Label = contact.Email.ToString();
        }
        async public void ContactAdded(Object sender,EventArgs e)
        {
            if (first == null)
            {
                await DisplayAlert("Error", "Can't be empty", "OK");
            }
            else
            {
                var _cont = new Contact
                {
                    FirstName=first.ToString(),LastName=last.ToString(),Phone=phone.ToString(),Email=ToString()
                };
                await Navigation.PushAsync(new ContactPage());
            }
        }
	}
}