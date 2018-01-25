using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PAMO
{
    public interface ISQLite
    {
       SQLiteConnection GetConnection();
    }
}
