using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DataAccess.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
