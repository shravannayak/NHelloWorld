using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using System.Linq;
using HelloWorld.Models;

namespace HelloWorld
{
    public class DBclass
    {
        private SQLiteConnection _connection;
        public DBclass()
        {
            _connection = DependencyService.Get<ISQLite>().GetConnection();
            _connection.CreateTable<ToDoListItem>();
        }
        public List<ToDoListItem> GetTodoItems()
        {
            return (from t in _connection.Table<ToDoListItem>() select t).ToList();
        }
        public void AddTodoItem(ToDoListItem item)
        {
            _connection.Insert(item);
        }
        public void AddTodoItems(List<ToDoListItem> items)
        {
            foreach (var item in items)
                _connection.Insert(item);
        }
    }
}
