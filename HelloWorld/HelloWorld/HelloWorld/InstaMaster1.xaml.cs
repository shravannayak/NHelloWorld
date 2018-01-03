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
    public partial class InstaMaster1 : MasterDetailPage
    {
        private List<Contact> _contacts;
        public InstaMaster1()
        {
            InitializeComponent();

            _contacts = GetContacts();
            listView.ItemsSource = _contacts;
        }
        
        /*public void CallClicked(Object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "Ok");
        }*/
        public void DeleteClicked(Object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }
        public void HandleRefresh(Object sender,EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
        }
        List<Contact> GetContacts(string searchText=null)
        {
            var contacts= new List<Contact>
            {
                new Contact {Name="Mosh",ImageUrl="http://lorempixel.com/100/100/people/1",},
                new Contact {Name="John",ImageUrl="http://lorempixel.com/100/100/people/2",Status="hey, let's talk"}
            };
            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;
            return contacts.Where(c => c.Name.StartsWith(searchText)).ToList();
        }
        public void Search(Object sender,TextChangedEventArgs e)
        {
            listView.ItemsSource=GetContacts(e.NewTextValue);
        }
        public void Selected(Object sender,SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Navigation.PushAsync(new InstaDetail1(contact));
        }
    }
}

