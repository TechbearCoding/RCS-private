using System.Data.SQLite;

namespace Day18_sqlite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Izveleties();
        }

        static void Izveleties()
        {
            Console.WriteLine("ko gribi izvadit : ");
            Console.WriteLine("1- klientu skaitu, ");
            Console.WriteLine("2- garako dziesmu, ");
            Console.WriteLine("3- klientu vardu un uzvardu un dziesmas kuras vini ir nopirkusi. ");
            int izvele = Convert.ToInt32(Console.ReadLine());

            SQLiteConnection conn = CreateConn();

            if (izvele == 1)
            {
                ReadCustomerCount(conn);
            }
            else if (izvele == 2)
            {
                ReadMaxTrack(conn);
            }
            else if (izvele == 3)
            {
                ReadCustomerTracks(conn);
            }

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

        private static void ReadCustomerTracks(SQLiteConnection conn)
        {
            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT (customers.firstName || ' ' || customers.LastName) as 'Client name',\r\ntracks.Name\r\n" +
                "FROM customers\r\nINNER JOIN invoices\r\n" +
                "ON customers.CustomerId = invoices.CustomerId\r\nINNER JOIN invoice_items\r\n" +
                "ON invoices.InvoiceId = invoice_items.InvoiceId\r\n" +
                "INNER JOIN tracks\r\nON tracks.TrackId = invoice_items.TrackId;";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                String customerName = sQLiteDataReader.GetString(0);
                String songName = sQLiteDataReader.GetString(1);

                Console.WriteLine(customerName + ": " + songName);
            }
        }
    }
}
