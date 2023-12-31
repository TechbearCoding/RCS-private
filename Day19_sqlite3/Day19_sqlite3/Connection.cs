using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_sqlite3
{
    public class Connection
    {
        public SqliteConnection conn { get; set; }

        public Connection()
        {
            conn = CreateConn();
        }

        public void CloseConn()
        {
            conn.Close();
        }
        private static SqliteConnection CreateConn()
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String dbPath = "chinook.db";
            String fullName = Path.Combine(desktopPath, dbPath);

            SqliteConnection sqlite_conn = new SqliteConnection("Data Source=" + fullName + ";");

            try
            {
                sqlite_conn.Open();
            }
            catch
            {
                Console.WriteLine("Error");
            }

            return sqlite_conn;
        }

    }
}
