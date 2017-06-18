using System;
using SQLite.Net.Attributes;

namespace SQLConnector
{
    public class SqliteItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set;}
        public string Test { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
