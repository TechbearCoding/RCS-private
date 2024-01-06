namespace Day19_sqlite3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connection connection = new Connection();


            String choice = "";
            while (choice != "0") 
            {
                Console.WriteLine("Izvelies, ko gribi darīt-");
                Console.WriteLine("1 - Ievadīt jaunu klientu");
                Console.WriteLine("2 - Izvadīt visus klientus");
                Console.WriteLine("3 - Izvadīt klientu pēc id");
                Console.WriteLine("0 - Iziet");
                
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Ievadi id!");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ievadi vārdu!");
                    String fname = Console.ReadLine();

                    Console.WriteLine("Ievadi uzvārdu!");
                    String lname = Console.ReadLine();

                    Console.WriteLine("Ievadi epastu!");
                    String mail = Console.ReadLine();

                    Customer customer = new Customer(id, fname, lname, mail);
                    CustomerQueries.InsertCustomer(connection.conn, customer);
                    Console.WriteLine("Vaicajums izpildits!");
                }
                else if (choice == "2")
                {

                    List<Customer> lst = CustomerQueries.DabutKlientus(connection.conn);

                    foreach (Customer customer in lst)
                    {
                        customer.Print();
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Ievadiet id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Customer c = CustomerQueries.DabutKlientuPecId(connection.conn, id);
                    c.Print();
                }
                else if(choice == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nepareiza ievade");
                }
            }
           
        }

        static void EmployeeSample()
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
