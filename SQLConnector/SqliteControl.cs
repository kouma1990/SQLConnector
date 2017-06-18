﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite.Net;

namespace SQLConnector
{
    class SqliteControl
    {
        static readonly object wObject = new object();
        readonly SQLiteConnection wSQLiteConnection;

        public SqliteControl()
        {
            wSQLiteConnection = DependencyService.Get<SqliteInterface>().GetConnection();
            wSQLiteConnection.CreateTable<SqliteItem>();
        }

        public IEnumerable<SqliteItem> GetItems()
        {
            lock (wObject)
            {
                return wSQLiteConnection.Table<SqliteItem>();
            }
        }

        public void InsertItem(SqliteItem item)
        {
            lock (wObject)
            {
                wSQLiteConnection.Insert(item);
            }
        }

        public void DeleteItem(SqliteItem item)
        {
            lock (wObject)
            {
                wSQLiteConnection.Delete(item);
            }
        }
    }
}
