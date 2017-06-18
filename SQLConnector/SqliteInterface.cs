using SQLite.Net;

namespace SQLConnector
{
    public interface SqliteInterface
    {
        SQLiteConnection GetConnection();        
    }
}
