﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HelloWorld
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
