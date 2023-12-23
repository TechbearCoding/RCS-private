using System.Data.SQLite;

namespace Day18_sqlite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection conn = Connections.CreateConn();
            Connections.CreateEmplList(conn);
        }

        static void Izveleties()
        {
            Console.WriteLine("ko gribi izvadit : ");
            Console.WriteLine("1- klientu skaitu, ");
            Console.WriteLine("2- garako dziesmu, ");
            Console.WriteLine("3- klientu vardu un uzvardu un dziesmas kuras vini ir nopirkusi. ");
            int izvele = Convert.ToInt32(Console.ReadLine());

            SQLiteConnection conn = Connections.CreateConn();

            if (izvele == 1)
            {
                Connections.ReadCustomerCount(conn);
            }
            else if (izvele == 2)
            {
                Connections.ReadMaxTrack(conn);
            }
            else if (izvele == 3)
            {
                Connections.ReadCustomerTracks(conn);
            }

            conn.Close();
        }

       
    }
}
