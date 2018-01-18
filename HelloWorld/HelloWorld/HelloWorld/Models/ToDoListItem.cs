using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HelloWorld.Models
{
    public class ToDoListItem
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string alpha { get; set; }
    }
}
