﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class Test
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Desc { get; set; }
    }
}
