namespace Day19_sqlite3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connection connection = new Connection();

            //Queries.InsertEmp(connection.conn);

            List<Employee> employees = Queries.CreateEmplList(connection.conn);

            foreach (Employee employee in employees)
            {
                employee.Print();
            }
        }
    }
}
