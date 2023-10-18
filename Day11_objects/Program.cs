namespace Day11_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivateSample.Run();
            Console.WriteLine(PrivateSample.a);

            Students.vards= "Janis";
            Students.uzvards = "Berzins";
            Students.PievienotAtzimi(8);
            Students.PievienotAtzimi(10);
            Students.PievienotAtzimi(4);

            Students.IzvaditInfo();
        }

    }
}