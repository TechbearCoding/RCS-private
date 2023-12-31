using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_sqlite3
{
    public class Connection
    {
        public SQLiteConnection conn { get; set; }

        public Connection()
        {
            conn = CreateConn();
        }

        public void CloseConn()
        {
            conn.Close();
        }
        private static SQLiteConnection CreateConn()
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String dbPath = "chinook.db";
            String fullName = Path.Combine(desktopPath, dbPath);

            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=" + fullName + "; Version=3");

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
