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
	public partial class ContactPage : ContentPage
	{
        private ObservableCollection<Contact> _cont;
		public ContactPage ()
		{
			InitializeComponent ();
            _cont = new ObservableCollection<Contact>
            {
                new Contact{FirstName="Shravan",LastName="Nayak",Email="shnk@gmail.com",Phone="9632897986"},
                new Contact{FirstName="Ajay",LastName="Shettigar",Email="ajay@gmail.com",Phone="9999988888"}
            };
            listView.ItemsSource = _cont;
		}
        public ContactPage(Contact cont)
        {
            InitializeComponent();
            
        }
        public void NewClicked(Object sender,EventArgs e)
        {
        
            Navigation.PushAsync(new ContactAD());
        }
        public void ItemSelected(Object sender,SelectedItemChangedEventArgs e)
        {

            var ContSelect = e.SelectedItem as Contact;
            Navigation.PushAsync(new ContactAD(ContSelect));
        }
        public void DeleteClicked(Object sender,EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _cont.Remove(contact);
        }
	}
}