using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;
using HelloWorld.Models;
using HelloWorld.CustomRenderer;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sql_CRUD : ContentPage
	{
        private SQLiteConnection _connection;
        private ObservableCollection<Test> _Test;
        private Test testEdit;

        public Sql_CRUD ()
		{
			InitializeComponent ();
            _connection = DependencyService.Get<ISQLite>().GetConnection();
        }

        protected override void OnAppearing()
        {
            _connection.CreateTable<Test>();
            var abc = _connection.Table<Test>().ToList();
            _Test = new ObservableCollection<Test>(abc);
            mylistview.ItemsSource = _Test;

            base.OnAppearing();
        }
        void BtnClick(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text=="ADD")
            {
                var Test = new Test { Title = TitleText.Text, Desc = DescriptionText.Text };
                _Test.Add(Test);
                _connection.Insert(Test);
                TitleText.Text = "";
                DescriptionText.Text = null;
                DependencyService.Get<ITostCustom>().ShowToast("Added");
            }
            else if(btn.Text=="EDIT")
            {
                testEdit.Title = TitleText.Text;
                testEdit.Desc = DescriptionText.Text;
                _connection.Update(testEdit);
                TitleText.Text = DescriptionText.Text = "";
                SaveBtn.Text = "ADD";
                DependencyService.Get<ITostCustom>().ShowToast("Edited");
                OnAppearing();
            }

        }
        void OnDelete(object sender, System.EventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            Test test = (Test)menu.CommandParameter;
            _Test.Remove(test);
            _connection.Delete(test);
            DependencyService.Get<ITostCustom>().ShowToast("Deleted");
        }

        void OnEdit(object sender, System.EventArgs e)
        {
            SaveBtn.Text = "EDIT";
            MenuItem menu = (MenuItem)sender;
            testEdit = (Test)menu.CommandParameter;
            TitleText.Text = testEdit.Title;
            DescriptionText.Text = testEdit.Desc;
        }
    }
}