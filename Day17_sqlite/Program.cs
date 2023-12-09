using System.Data.SQLite;

namespace Day17_sqlite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection conn = CreateConn();
            ReadCustomerCount(conn);
            conn.Close();
        }

        private static void ReadCustomerCount(SQLiteConnection conn)
        {
            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(customers.CustomerId) FROM customers";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                int line = sQLiteDataReader.GetInt32(0);
                Console.WriteLine(line);
            }

        }

        private static void ReadMaxTrack(SQLiteConnection conn)
        {
            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT tracks.Name, MAX(tracks.Milliseconds)\r\nFROM tracks;";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                String name = sQLiteDataReader.GetString(0);
                int line = sQLiteDataReader.GetInt32(1);

                Console.WriteLine(name + ": " + line);
            }

        }

        public static SQLiteConnection CreateConn()
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String dbPath = "chinook.db";
            String fullName = Path.Combine(desktopPath, dbPath);
            
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source="+ fullName + "; Version=3");

            try
            {
                sqlite_conn.Open();
                Console.WriteLine("sqlite works!");
            }
            catch
            {
                Console.WriteLine("Error");
            }

            return sqlite_conn;
        }
    }

}
