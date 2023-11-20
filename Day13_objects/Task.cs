using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_objects
{
    public class Task
    {
        public static void RunTask()
        {
            Izvele();
        }

        static void IeliktSkaitlus(bool append)
        {
            String filename = "data.txt";
            try
            {
                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, filename);
                StreamWriter file = new StreamWriter(fullName, append);

                for (int i = 0; i < 10; i++)
                {
                    int skaitli = Convert.ToInt32(Console.ReadLine());
                    file.WriteLine(skaitli);
                }
                file.Flush();
                file.Dispose();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            
        }

        static void OpenFile(String filename)
        {
            try
            {
                Console.WriteLine("Vai gribi atvert mapi ? Ja/Ne");
                String atbilde = Console.ReadLine();

                if (atbilde == "Ja")
                {
                    List<int> lists = new List<int>();

                    String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    String fullName = Path.Combine(desktopPath, filename);

                    StreamReader sr = new StreamReader(fullName);

                    String line = sr.ReadLine();

                    while (line != null)
                    {
                        lists.Add(Convert.ToInt32(line));
                        line = sr.ReadLine();
                    }
                    ReadFile(lists);
                }
                else if (atbilde == "No")
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
        }

        static void ReadFile(List<int> lists)
        {
            for (int i = 0; i < lists.Count; i++)
            {
                Console.Write(lists[i] + " ; ");
            }
            Console.WriteLine();
        }

        static void Izvele()
        {

            Console.WriteLine("Vai gribi ievadit 10 jaunus skaitlus un vecos dzest ?");
            String izvele = Console.ReadLine();

            if (izvele == "Ja")
            {
                IeliktSkaitlus(true);
                OpenFile("data.txt");
            }
            else if (izvele == "Ne")
            {
                return;
            }

        }
    }
}
