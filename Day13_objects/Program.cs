namespace Day13_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FIleIO.IevaditVertibas("test4.txt");
            FIleIO.ReadFile("test4.txt");
        }

        static void Sample() 
        {
            Console.WriteLine("Ievadi skaitli!");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a);
            }
            catch
            {
                Console.WriteLine("Ir jaievada skaitlis!");
            }

        }
    }
}