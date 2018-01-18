using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloWorld.Models;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageNewEdited : ContentPage
	{
        public ToDoListItem Model
        {
            get { return (ToDoListItem)BindingContext; }
            set
            {
                BindingContext = value;
                OnPropertyChanged();
            }
        }

		public PageNewEdited (ToDoListItem _model)
		{
            Model = _model;
            Title = "Edit";
			InitializeComponent ();
		}
        public async void OnSave(object sender,EventArgs e)
        {
            if ((string.IsNullOrEmpty(Model.title)) == true)
                return;
            new DBclass().EditItem(Model);
            await DisplayAlert("Note", "Changes Saved!", "OK");
            await Navigation.PopAsync();
        }
	}
}