﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_sqlite3
{
    public class Queries
    {
        public static List<Employee> CreateEmplList(SqliteConnection conn)
        {
            List<Employee> employees = new List<Employee>();

            SqliteDataReader sQLiteDataReader;
            SqliteCommand cmd = conn.CreateCommand();
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

                employees.Add(new Employee(id, employeeName, employeeLastName, city, country));
            }

            return employees;
        }

        public static void InsertEmp(SqliteConnection conn, int id, String vards, String uzvards, String city, String country)
        {
            SqliteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO Employees(EmployeeId, FirstName, Lastname, city, country) " +
                "VALUES (@id, @firstName, @lastName, @city, @country)";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@firstName", vards);
            cmd.Parameters.AddWithValue("@lastName", uzvards);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@country", country);

            cmd.ExecuteNonQuery();
        }
    }
}
