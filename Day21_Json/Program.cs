using System.Text.Json;

namespace Day21_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee(1, "Janis", "Berzins", "Riga", "Latvia");
            String json = JsonSerializer.Serialize(em);
            //Console.WriteLine(json);

            List<Employee> employees = new List<Employee>();
            employees.Add(em);
            employees.Add(new Employee(2, "Peteris", "Liepa", "Riga", "Latvia"));
            employees.Add(new Employee(3, "Anna", "Ozola", "Riga", "Latvia"));
            employees.Add(new Employee(4, "Liga", "Kaktina", "Riga", "Latvia"));

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            String json2 = JsonSerializer.Serialize(employees, options);
            //Console.WriteLine(json2);


            //------------------------------------------------------------
            Employee e = JsonSerializer.Deserialize<Employee>(json);
            //e.Print();

            List<Employee> employees2 = JsonSerializer.Deserialize<List<Employee>>(json2);
            foreach (Employee emp in employees2)
            {
                emp.Print();
            }

        }
    }
}
