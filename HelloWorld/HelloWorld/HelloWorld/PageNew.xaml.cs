using HelloWorld.Models;
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
	public partial class PageNew : ContentPage
	{
		public PageNew ()
		{
			InitializeComponent ();
            CheckDatabasePopulated();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = GetToDoList();

        }
        public async void OnItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            ((ListView)sender).SelectedItem = null;
            await Navigation.PushAsync(new PageNewEdited((ToDoListItem)e.SelectedItem));
        }
        List<ToDoListItem> GetToDoList()
        {
            var items = new DBclass().GetTodoItems();
            return items;
        }
        void CheckDatabasePopulated()
        {
            if(new DBclass().GetTodoItems().Count<1)
            {
                var items = new List<ToDoListItem>();
                for(int i=0;i<10;i++)
                {
                    items.Add(new ToDoListItem()
                    {
                        title = "Task" + (i + 1).ToString(),
                        content = "Description - Tap to edit",
                        alpha = (1 - ((double)i / 20)).ToString()
                    });
                }
                new DBclass().AddTodoItems(items);
            }
        }
	}
}