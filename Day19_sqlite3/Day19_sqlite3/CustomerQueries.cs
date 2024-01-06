using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_sqlite3
{
    public class CustomerQueries
    {
        public static List<Customer> DabutKlientus(SqliteConnection conn)
        {
            List<Customer> customers = new List<Customer>();
            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT customers.CustomerId, customers.FirstName, customers.LastName, customers.Email " +
                "FROM customers;";

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                int customerId = sQLiteDataReader.GetInt32(0);
                String firstName = sQLiteDataReader.GetString(1);
                String lastName = sQLiteDataReader.GetString(2);
                String email = sQLiteDataReader.GetString(3);

                customers.Add(new Customer(customerId, firstName, lastName, email));
            }
            return customers;
        }

        public static Customer DabutKlientuPecId(SqliteConnection conn, int id)
        {
            Customer customer = new Customer();
            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                "SELECT customers.CustomerId, customers.FirstName, customers.LastName, customers.Email " +
                "FROM customers WHERE customers.CustomerId = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            sQLiteDataReader = cmd.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                int customerId = sQLiteDataReader.GetInt32(0);
                String firstName = sQLiteDataReader.GetString(1);
                String lastName = sQLiteDataReader.GetString(2);
                String email = sQLiteDataReader.GetString(3);

                customer.id = customerId;
                customer.vards = firstName;
                customer.uzvards = lastName;
                customer.epasts = email;
            }
            return customer;
        }

        public static void InsertCustomer(SqliteConnection conn, Customer c)
        {
            SqliteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO customers(CustomerId, FirstName, LastName, Email) " +
                "VALUES (@id, @firstName, @lastName, @email)";

            cmd.Parameters.AddWithValue("@id", c.id);
            cmd.Parameters.AddWithValue("@firstName", c.vards);
            cmd.Parameters.AddWithValue("@lastName", c.uzvards);
            cmd.Parameters.AddWithValue("@email", c.epasts);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("SQL error");
            }
            
        }
    }
}
