using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public class Recipe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        private string _name;
        [MaxLength(255)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                    return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPage : ContentPage
	{
        private SQLiteConnection _connection;
        private ObservableCollection<Recipe> _recipes;
		public NewPage ()
		{
			InitializeComponent ();
            _connection = DependencyService.Get<ISQLite>().GetConnection();
        }

        protected override void OnAppearing()
        {
            _connection.CreateTable<Recipe>();
            var recipes=_connection.Table<Recipe>().ToList();
            _recipes=new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;
            base.OnAppearing();
        }

        void OnAdd(object sender, System.EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe " + DateTime.Now.Ticks };
            _connection.Insert(recipe);
            _recipes.Add(recipe);
        }

        void OnUpdate(object sender, System.EventArgs e)
        {
            var recipe = _recipes[0];
            recipe.Name += " UPDATED";
            _connection.Update(recipe);
        }

        void OnDelete(object sender, System.EventArgs e)
        {
            var recipe = _recipes[0];
            _connection.Delete(recipe);
            _recipes.Remove(recipe);
        }
    }
}