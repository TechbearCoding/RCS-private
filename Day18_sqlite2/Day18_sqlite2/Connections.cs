using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace Day18_sqlite2
{
    public class Connections
    {
        public static SQLiteConnection CreateConn()
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

        public static void ReadCustomerCount(SQLiteConnection conn)
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

        public static void ReadEmployeeInfo(SQLiteConnection conn)
        {
            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT(employees.FirstName || ' ' || employees.LastName) as 'Employee name', employees.Title, employees.City,employees.Country " +
                "FROM employees;";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                String employeeName = sQLiteDataReader.GetString(0);
                String employeeInfo = sQLiteDataReader.GetString(1);
                String city = sQLiteDataReader.GetString(2);
                String country = sQLiteDataReader.GetString(3);
                

                Console.WriteLine(employeeName + ": " + employeeInfo);
                Console.WriteLine(country + ", " + city);
                Console.WriteLine("------------");
            }
        }

        public static void ReadMaxTrack(SQLiteConnection conn)
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

        public static void ReadCustomerTracks(SQLiteConnection conn)
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

        public static List<Employee> CreateEmplList(SQLiteConnection conn)
        {
            List<Employee> employees = new List<Employee>();

            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT employees.EmployeeId, employees.FirstName, employees.LastName, employees.City, employees.Country " +
                "FROM employees;";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                int id = sQLiteDataReader.GetInt32(0);
                String employeeName = sQLiteDataReader.GetString(1);
                String employeeLastName = sQLiteDataReader.GetString(2);
                String city = sQLiteDataReader.GetString(3);
                String country = sQLiteDataReader.GetString(4);

                employees.Add(new Employee(id, employeeName, employeeLastName, city, country)); //sis ir piemērs
            }

            return employees;
        }
    }
}
