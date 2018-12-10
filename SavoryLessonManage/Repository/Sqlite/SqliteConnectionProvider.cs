using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace SavoryLessonManage.Repository.Sqlite
{
    public class SqliteConnectionProvider
    {
        public IDbConnection GetConnection()
        {
            var connString = ConfigurationManager.ConnectionStrings["SavoryLessonSqlite"].ConnectionString;

            SQLiteConnection connection = new SQLiteConnection(connString);
            connection.Open();

            return connection;
        }
    }
}
