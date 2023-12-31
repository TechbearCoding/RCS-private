using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_sqlite3
{
    public class Queries
    {
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

        public static void InsertEmp(SQLiteConnection conn)
        {
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO Employees(EmployeeId, FirstName, Lastname, city, country) " +
                "VALUES (@id, @firstName, @lastName, @city, @country)";

            cmd.Parameters.AddWithValue("@id", 99);
            cmd.Parameters.AddWithValue("@firstName", "John");
            cmd.Parameters.AddWithValue("@lastName", "Doe");
            cmd.Parameters.AddWithValue("@city", "Riga");
            cmd.Parameters.AddWithValue("@country", "Latvia");

            cmd.ExecuteNonQuery();
        }
    }
}
